using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound_API.Filtros
{
    internal class LinqFilter
    {
        public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
        {
            var todosOsGenerosMusicais = musicas.Select(generos => 
            generos.Genero).Distinct().ToList();
            foreach(var genero in todosOsGenerosMusicais)
            {
                Console.WriteLine($"- {genero}");
            }
        }
        public static void FiltrarAritistasPorGeneroMusical(List<Musica> musicas, string genero)
        {
            var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(
                musica => musica.Artista).Distinct().ToList();
            Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");
            foreach (var artista in artistasPorGeneroMusical)
            {
                Console.WriteLine($"- {artista}");
            }
        }
        public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
        {
            var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
            Console.WriteLine(nomeDoArtista);
            foreach (var musica in musicasDoArtista)
            {
                Console.WriteLine($"- {musica.Nome}");
            }
        }
        public static void FiltrarMusicasPorTonalidade(List<Musica> musicas, string tom)
        {
            var musicasPorTom = musicas.Where(musica => musica.Tonalidade.Equals(tom)).Select(
                musica => musica.Nome).ToList();
            Console.WriteLine($"Exibindo as musicas por Tom musical >>> {tom}");
            foreach (var musica in musicasPorTom)
            {
                Console.WriteLine($"- {musica}");
            }
        }
    }
}
