using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Atividades.FormasGeometricas
{
	internal class Triangulo:FormaGeometrica
	{
		public Triangulo()
		{
		}
		public Triangulo(float altura, float largura) : base(altura, largura)
		{
		}
		public override float CalcularArea()
		{
			return (Altura * Largura)/2;
		}
	}
}
