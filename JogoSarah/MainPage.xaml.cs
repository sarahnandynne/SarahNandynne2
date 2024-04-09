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

