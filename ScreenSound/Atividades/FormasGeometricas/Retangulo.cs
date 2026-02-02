using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Atividades.FormasGeometricas
{
	internal class Retangulo : FormaGeometrica
	{
		public Retangulo()
		{
		}
		public Retangulo(float altura, float largura) : base(altura, largura)
		{
		}
		public override float CalcularArea()
		{
			return Altura * Largura;
		}
	}
}
