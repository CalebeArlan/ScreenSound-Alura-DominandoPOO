using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Atividades.Filmes
{
	public class Filme
	{
		public Filme() { }
		public Filme(string titulo, int duracao)
		{
			Titulo = titulo;
			Duracao = duracao;
		}
		public string Titulo { get; set; }
		public int Duracao { get; set; }

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
