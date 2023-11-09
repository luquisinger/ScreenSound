﻿using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound_API.Filtros;

internal class LinqOrder
{
    public static void ExibirArtistasOrdenados(List<Musica>musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => 
        musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine("Lista de artistas ordenados");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
