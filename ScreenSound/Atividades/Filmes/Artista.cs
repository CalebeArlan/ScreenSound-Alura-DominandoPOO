using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Atividades.Filmes
{
	internal class Artista
	{
		public Artista() { }
		public Artista(string nome, int idade)
		{
			Nome = nome;
			Idade = idade;
		}
		public string Nome { get; set; }
		public int Idade { get; set; }
		public List<Filme> Filmes { get; set; } = new List<Filme>();
	}
}
