using ScreenSound.Menus;
using ScreenSound.Modelos;

internal class MenuSair : Menu
{
	public virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
	{
		Console.WriteLine("Tchau tchau :)");
	}

}