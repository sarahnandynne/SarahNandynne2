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
		
	}
	void DarAgua(object sender, EventArgs args)
	{

	}
	void DarComida(object sender, EventArgs args)
	{

	}
	void Brincar(object sender, EventArgs args)
	{
		
	}

}

