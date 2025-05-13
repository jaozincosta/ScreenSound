Episodio ep1 = new(1, "Técnicas de facilitação", 45);
ep1.AdicionarConvidado("Maria");
ep1.AdicionarConvidado("Marcelo");


Episodio ep2 = new(2, "Técnicas de aprendizado", 67);
ep1.AdicionarConvidado("Fernando");
ep1.AdicionarConvidado("Marco");
ep1.AdicionarConvidado("Joao");

Podcast podcast = new("Podcast", "joao");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();
