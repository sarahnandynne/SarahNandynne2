using Microsoft.Maui.Controls;

namespace JogoSarah;

public partial class MainPage : ContentPage
{
	Personagens atual;
	Joaninha ladybug;
	Abelha zeebee;
	Borboleta butterfly;
	public MainPage()
	{
		InitializeComponent();

		ladybug 	= new Joaninha();
		zeebee 		= new Abelha();
		butterfly 	= new Borboleta();

		atual = ladybug;

		personagens.Source = atual.GetArquivo();
		pbAgua.Progress=atual.GetSede();
		pbComida.Progress=atual.GetFome();
		pbTristeza.Progress=atual.GetTristeza();

		var timer =
		Application.Current.Dispatcher.CreateTimer();
		timer.Interval = TimeSpan.FromSeconds(3);
		timer.Tick += (s,e) => PassouTempo();
		timer.Start();
	}
		void PassouTempo()
		{
			var estavaMorto = atual.GetMorto();

			atual.SetSede(atual.GetSede() - 0.1);
			pbAgua.Progress=atual.GetSede();

			atual.SetFome(atual.GetFome() - 0.1);
			pbComida.Progress=atual.GetFome();

			atual.SetTristeza(atual.GetTristeza() - 0.1);
			pbTristeza.Progress=atual.GetTristeza();

			if (estavaMorto != atual.GetMorto())
				personagens.Source = atual.GetArquivo();
		}
		
		void GameOver()
		{
			if (butterfly.GetMorto() &&
				zeebee.GetMorto() &&
				ladybug.GetMorto())
			{
			Application.Current.MainPage = new GameOverPage();
			}
		}


	void Mudar(object sender, EventArgs args)
	{
		if (atual == ladybug)
			atual = zeebee;
		else if (atual == zeebee)
			atual = butterfly;
		else
			atual = ladybug;

		personagens.Source = atual.GetArquivo();
		pbAgua.Progress = atual.GetSede();
		pbComida.Progress = atual.GetFome();
		pbTristeza.Progress = atual.GetTristeza();
		
	}
	void DarAgua(object sender, EventArgs args)
	{
		atual.SetSede(atual.GetSede() + 0.1);
		pbAgua.Progress=atual.GetSede();
	}
	void DarComida(object sender, EventArgs args)
	{
		atual.SetFome(atual.GetFome() + 0.1);
		pbComida.Progress=atual.GetFome();
	}
	void Brincar(object sender, EventArgs args)
	{
		atual.SetTristeza(atual.GetTristeza() + 0.1);
		pbTristeza.Progress=atual.GetTristeza();
	}


}

