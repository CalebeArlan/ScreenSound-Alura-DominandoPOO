using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Atividades.FormasGeometricas
{
	internal class FormaGeometrica
	{
		public FormaGeometrica() { }
		public FormaGeometrica(float altura, float largura)
		{
			Altura = altura;
			Largura = largura;
		}

		protected float Altura, Largura;

		public virtual float CalcularArea()
		{
			return 0;
		}

		public virtual void Apresentar()
		{
			Console.WriteLine("Digite a altura da forma geométrica:");
			Altura = float.Parse(Console.ReadLine());
			Console.WriteLine("Digite a largura da forma geométrica:");
			Largura = float.Parse(Console.ReadLine());
			Console.WriteLine($"A área da forma geométrica é: {CalcularArea()}");
			Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
			Console.ReadKey();
			Console.Clear();
			MenuFormasGeometricas.Menu();
		}
	}
}
