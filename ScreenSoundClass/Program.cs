Album albumDoColdplay = new Album();
albumDoColdplay.Nome = "A Rush of Blood to the Head";

Musica musica1 = new Musica();
musica1.Nome = "The Scientist";
musica1.Duracao = 213;

Musica musica2 = new Musica();
musica2.Nome = "Clocks";
musica2.Duracao = 350;

albumDoColdplay.AdicionarMusica(musica1);
albumDoColdplay.AdicionarMusica(musica2);

albumDoColdplay.ExibirMusicasDoAlbum();