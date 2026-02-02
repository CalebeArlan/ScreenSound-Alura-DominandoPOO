using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Atividades.FormasGeometricas
{
	internal class MenuFormasGeometricas
	{
		public static void Menu()
		{
			Console.WriteLine("Escolha a forma geométrica para calcular a área.\n1 - Retangulo;\n2 - Triangulo\n3 - Circulo\n0 - Sair\n\nDigite a opção desejada: ");
			int opcao = int.Parse(Console.ReadLine());	

			switch (opcao)
			{
				case 1:
					Retangulo retangulo = new Retangulo();
					retangulo.Apresentar();
					break;
				case 2:
					Triangulo triangulo = new Triangulo();
					triangulo.Apresentar();
					break;
				case 3:
					Circulo circulo = new Circulo();
					circulo.Apresentar();
					break;
				case 0:
					Console.WriteLine("Saindo...");
					break;
				default: break;
			}
		}
	}
}
