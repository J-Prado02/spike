using System;

class Atleta
{
    static void Main()
    {
        Lutador[] lutadores = new Lutador[6];

        lutadores[0] = new Lutador("Aquiles", "Grécia", 28, 1.90, 92.0, 40, 2, 1);
        lutadores[1] = new Lutador("Hércules", "Grécia", 35, 2.00, 110.0, 60, 3, 0);
        lutadores[2] = new Lutador("Beowulf", "Escandinávia", 32, 1.95, 100.0, 45, 1, 0);
        lutadores[3] = new Lutador("Miyamoto Musashi", "Japão", 30, 1.80, 80.0, 61, 0, 0);
        lutadores[4] = new Lutador("Espártaco", "Trácia", 34, 1.88, 95.0, 50, 5, 2);
        lutadores[5] = new Lutador("Guan Yu", "China", 36, 1.92, 102.0, 55, 4, 1);

        Luta evento01 = new Luta();

        evento01.marcarLuta(lutadores[0], lutadores[1]);
        evento01.lutar();

        lutadores[0].Status();
        lutadores[1].Status();

    }
}