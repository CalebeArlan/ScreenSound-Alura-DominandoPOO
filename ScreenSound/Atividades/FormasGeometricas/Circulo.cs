using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Atividades.FormasGeometricas
{
	internal class Circulo: FormaGeometrica
	{
		public Circulo()
		{
		}
		public Circulo(float raio, float _) : base(raio, raio)
		{
		}

		public override void Apresentar()
		{
			Console.WriteLine("Digite o raio do círculo:");
			Largura = float.Parse(Console.ReadLine());
			Console.WriteLine($"A área do círculo é: {CalcularArea()}");
			Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
			Console.ReadKey();
			Console.Clear();
			MenuFormasGeometricas.Menu();
		}
		public override float CalcularArea()
		{
			float raio = Largura / 2;
			return 3.14f * (raio * raio);
		}
	}
}
