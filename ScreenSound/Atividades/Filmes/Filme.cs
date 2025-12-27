using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Atividades.Filmes
{
	internal class Filme
	{
		internal Filme() { }
		public Filme(string titulo, int duracao)
		{
			Titulo = titulo;
			Duracao = duracao;
		}
		internal string Titulo { get; set; }
		internal int Duracao { get; set; }

		public List<Artista> Artistas { get;} = new List<Artista>();

		public void AdicionarArtista(Artista artista)
		{
			if (artista == null)
			{
				throw new ArgumentNullException(nameof(artista), "Artista não pode ser nulo.");
			}
			if (Artistas.Contains(artista))
			{
				throw new InvalidOperationException("Artista já adicionado ao filme.");
			}
			Artistas.Add(artista);
			artista.Filmes.Add(this);
		}
	}
}
