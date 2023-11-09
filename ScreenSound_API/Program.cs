using ScreenSound.Modelos;
using ScreenSound_API.Filtros;
using ScreenSound_API.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Desserializacao é transformar o JSON para o que a linguagem usa
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirArtistasOrdenados(musicas);
        //LinqFilter.FiltrarAritistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");

        var minhasMusicasPreferidas = new MusicasFavoritas("Mathues");
        minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[1]);
        minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[65]);
        minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[1532]);
        minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[56]);
        minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[21]);

        //minhasMusicasPreferidas.ExibirMusicasFavoritas();
        //minhasMusicasPreferidas.GerarArquivoJson();

        //var musicasFavoritasDoGuilherme = new MusicasFavoritas("Guilherme");
        //musicasFavoritasDoGuilherme.AdicionarMusicasFavoritas(musicas[980]);
        //musicasFavoritasDoGuilherme.AdicionarMusicasFavoritas(musicas[513]);
        //musicasFavoritasDoGuilherme.AdicionarMusicasFavoritas(musicas[1024]);
        //musicasFavoritasDoGuilherme.AdicionarMusicasFavoritas(musicas[999]);
        //musicasFavoritasDoGuilherme.AdicionarMusicasFavoritas(musicas[37]);

        //musicasFavoritasDoGuilherme.GerarDocumentoTXTComAsMusicasFavoritas();

        LinqFilter.FiltrarMusicasPorTonalidade(musicas, "C#");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
