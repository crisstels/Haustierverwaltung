using ZooTiere;

Goldfisch goldfisch = new Goldfisch("Günther", "Günther");
Guppy guppy = new Guppy("Karl", "Karl");

Fisch[] aquarium = new Fisch[50];
int j = 0;

// Aquarium intialsieren

for (int i = 0; i < aquarium.Length; i++)
{
    if (i % 2 == 0)
    {
        if (j % 2 == 0)
        {
            aquarium[i] = new Goldfisch($"Goldfisch {i}", $"Besitzer: {i}");

        }
        else
        {
            aquarium[i] = new Guppy($"Guppy {i}", $"Besitzer: {i}");
        }
        j++;

    }

}

for (int i = 0; i < aquarium.Length; i++)
{
    if (aquarium[i] != null)
    {
        aquarium[i].schwimmen();
        aquarium[i].Pflegen();

        if (aquarium[i] is Goldfisch)
        {
            ((Goldfisch)aquarium[i]).Streicheln();
        }
    }

}

Saeuger[] garten = new Saeuger[10];

for (int i = 0; i < garten.Length; i++)
{
    if (i % 2 == 0)
    {
        garten[i] = new Katze($"Katze {i}", $"Besitzer: {i}");
    }
    else
    {
        garten[i] = new Kaninchen($"Kaninchen {i}", $"Besitzer: {i}");
    }
}

foreach (Saeuger s in garten)
{
    s.fortbewegen();
    s.Pflegen();
    s.Streicheln();
}

Haustier[][] zoo = new Haustier[2][];
zoo[0] = garten;
zoo[1] = aquarium;

foreach (Haustier[] h in zoo)
{
    foreach (Haustier h2 in h)
    {
        h2?.Pflegen();
        Console.WriteLine(h2?.ToString());
    }
}



guppy.schwimmen();
guppy.Pflegen();
goldfisch.schwimmen();
goldfisch.Pflegen();
