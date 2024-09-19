Banda queen = new("Queen");

Album albumQueen = new("A night at the opera");

Musica musica1 = new(queen, "Love of my life")
{
    // Inicializando propriedades opcionais de forma simplificada
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new(queen, "Bohemian Rhapsody")
{
    // Inicializando propriedades opcionais de forma simplificada
    Duracao = 354,
    Disponivel = false,
};

albumQueen.AdicionarMusica(musica1);
albumQueen.AdicionarMusica(musica2);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

albumQueen.ExibirMusicas();

queen.AddAlbum(albumQueen);
queen.ExibirDiscografia();