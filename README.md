# PE Judo

Lees eerst de volledige opgave alvorens aan deze opdracht te beginnen.

## Werking opdracht
### Opstarten van de applicatie
- Titel van het window verandert naar "Judoref - [Voornaam Achternaam]" (gebruik je echte naam!)
- In beide comboboxen worden alle kleuren van de gordels opgeladen. Doe dit aan de hand van een eigen gemaakte methode `VulComboboxGordels` waarin je beide comboboxen opvult. Je gebruikt hiervoor volgende kleuren:
  - wit
  - geel
  - oranje
  - groen
  - blauw
  - bruin
  - zwart
- Je verbergt de stackpanels die score 1 en 2 tonen. 
- Je verbergt de listbox scoretabel
- Je verbergt de button die de wedstrijd doet stoppen.
- Voorbeeld beginscherm:
![Image of start](/images/pe-judoref-01.png)

### Voor het starten van een kamp
- Men vult voor beide judoka's die deelnemen aan het kamp de namen in. Doe dit in de voorziene textboxen.
- Men kies voor elke judoka welk kleur van gordel deze bezit. Dit gebeurt via de voorziene comboboxen.
- Men drukt op de knop **Start Kamp**

### Na het starten van een kamp 
- Wanneer men op de knop **Start Kamp** drukt, voorzie dan het volgende:
    - De knoppen in de **stackpanels** om de scores te bepalen komen zichtbaar per judoka (Koka, Yuko, Wazeri, Ippon). 
    - De knop **Stop wedstrijd** wordt zichtbaar
    - De **textblock** met de scoretabel wordt zichtbaar en krijgt als eerste inhoud "Start kamp tussen [*naam judoka 1*] (Gordel [*kleur gordel judoka 1*]) en [*naam judoka 2*] (Gordel [*kleur gordel judoka 2*])
- Voorbeeld:
![Image of start](/images/pe-judoref-02.png)

### Tijdens de kamp
- Men kan op de score buttons (Koka, Yuko, Wazeri, Ippon) drukken per judoka
- Bij het drukken op een score button
    - worden de punten bijgeteld bij de score van de betreffende judoka en wordt het label met de score aangepast.
    - wordt de listbox scoretabel aangevuld met de datum en uur van de score, gevolgd door de naam van de speler die scoort, het kleur van zijn gordel, het aantal punten en welke actie (Koka, Yuko, Wazeri, Ippon). Zie screenshot.
- Voorbeeld:
![Image of start](/images/pe-judoref-03.png)

### Stoppen van de kamp
- Wanneer men klikt op de knop **Stop wedstrijd** wordt alles terug gezet om een nieuwe wedstrijd te kunnen laten beginnen.
- Voorbeeld:
![Image of start](/images/pe-judoref-01.png)

## Te voorziene methodes
Jullie moeten volgende methodes aanmaken en gebruiken in jullie uitwerking:
- `private void VulComboboxGordels()`
- `private void BeginSituatie()`
- `private void UpdateGuiStartKamp()`
- `private void VerwerkScoreJudoka1(int punten, string scoreNaam)`
- `private void VerwerkScoreJudoka2(int punten, string scoreNaam)`

De code in deze methodes schrijven jullie zelf, maar jullie zijn verplicht om gebruik te maken van bovenstaande vijf methodes. 


## Vereisten van deze opdracht
- Deze opdracht wordt **individueel** gemaakt!
- Zorg ervoor dat er **geen errors** aanwezig zijn bij de ingediende versie
- Volg de afspraken omtrent hoofdletter gebruik (variabelen, methodes). Bekijk deze de afspraken zeker nog eens in de cursus.
- De code van de **laatste commit voor de deadline** van de opdracht zal verbeterd worden. Commits die gebeuren na de deadline worden niet verbeterd.
- Controleer zelf online op GitHub of je code effectief gepushed werd naar je online repository.

Véél succes!



