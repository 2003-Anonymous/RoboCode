# RoboCode

Huete habe ich RoboCode installiert. Zuerst hatte ich einige Probleme mit Java, da die Installation der neusten Version zuerst nicht funktioniert hat. Dann habe ich einen neuen Roboter erstellt und dort mit der Feuerkraft und Bewegungsrichtungen herumexperimentiert. Anschliessend habe ich noch alle Roboter gegeneinander kämpfen lassen. Der Borderguard hat immer gewonnen, da er viel mehr Leben als die anderen Bots hatte.

## 19.06.26

- [ ] Die Steuerung meines Roboters verbessern, damit er sich in einem Quadrat bewegt.
- [ ] Den Code vom Borderguard genauer anschauen und herauszufinden, warum er so viele Leben hat.
- [x] Roboter von anderen anschauen, um verschiedene Bewegungsalgorithmen kennenzulernen.
- [x] Anschauen wie man Roboter in C# programmiert und einen mit dem vorhin Gelerntem erstellen.

Heute habe ich versucht, einen Roboter in C# zu programmieren. Als ich die wichtigsten Dateien erstellt habe und den Roboter testen wollte, habe ich gemerkt, dass es zwei verschiedene Versionen von RoboCode gibt und ich die andere benötige. Als ich diese dann installiert habe, habe ich nochmals versucht, den Roboter zu importieren, aber das hat nicht funktioniert. Ich habe dann noch im internet recherchiert und Claude gefragt aber ich habe das Problem nicht gefunden. Das alles hat sehr viel Zeit gekostet und ich bin mir jetzt nicht ganz sicher, ob und wie gut mein Roboter funktioniert.
So sollte er funktionieren:
MyFirstBot ist ein Robocode-Kampfroboter, der sein Radar unabhängig von Körper und Kanone dreht, um den Gegner dauerhaft im Blick zu behalten. Sobald ein Feind entdeckt wird, fixiert das Radar ihn automatisch. Statt direkt auf den Gegner zu zielen, berechnet der Roboter dessen zukünftige Position und trifft so auch bewegende Ziele zuverlässig. Die Feuerkraft passt er dabei der Distanz an und aus der Nähe schiesst er mit maximaler Stärke. Um selbst schwerer treffbar zu sein, bewegt er sich stets seitlich zum Gegner und wechselt bei Treffern oder Wandkontakt sofort die Richtung. Kollidiert er direkt mit einem Feind, feuert er automatisch mit voller Kraft.
