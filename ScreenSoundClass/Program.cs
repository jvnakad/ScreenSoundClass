//banda coldplay = new banda("coldplay");

//album albumdocoldplay = new album("a rush of blood to the head");

//musica musica1 = new musica(coldplay, "the scientist")
//{
//    duracao = 213,
//    disponivel = false,
//};

//musica musica2 = new musica(coldplay, "clocks")
//{
//    duracao = 350,
//    disponivel = true,
//};

//albumdocoldplay.adicionarmusica(musica1);
//albumdocoldplay.adicionarmusica(musica2);
//coldplay.adicionaralbum(albumdocoldplay);

//musica1.exibirfichatecnica();
//musica2.exibirfichatecnica();
//albumdocoldplay.exibirmusicasdoalbum();


//coldplay.exibirdiscografia();

Episodio ep1 = new Episodio(1, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("joao");
ep1.AdicionarConvidados("isa");


Episodio ep2 = new Episodio(2, "Técnicas de aprendizado", 67);
ep2.AdicionarConvidados("alice");
ep2.AdicionarConvidados("marcos");
ep2.AdicionarConvidados("adri");

Podcast podcast = new("Podast especial", "Naka");
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep1);
podcast.ExibirDetalhes();