# 📩 Loonstrook Verzender

Dit project is ontwikkeld voor **Restaurant Chalet Couvert**.  
Het doel van deze applicatie is het automatiseren van het proces rondom het **splitsen, hernoemen en verzenden van loonstroken**, zodat de eigenaar/manager niet langer handmatig tientallen loonstroken hoeft te verwerken.

---

## ⚙️ Probleemstelling
Voorheen kreeg de manager één groot PDF-document met ~70 loonstroken.  
Om deze te versturen moest hij:
1. De PDF opsplitsen in losse bestanden.  
2. Elk bestand hernoemen met de juiste naam en ID van de werknemer.  
3. Handmatig alle bestanden verzenden naar de werknemers.  

Dit proces was tijdrovend en foutgevoelig.  

---

## 🚀 Het Project
   
### Belangrijkste functionaliteiten:
- **Inloggen met zakelijke mail**  
  - Ondersteunde mailproviders: `one.com`, `Gmail`, `Outlook`  
  - Inloggegevens worden **geëncrypteerd** opgeslagen in een database.  

- **Accountvalidatie via e-mail**  
  - Bij het aanmaken van een account wordt een **testmail** gestuurd naar mij.  
  - Deze bevat een unieke **verificatiecode** die de gebruiker moet invoeren.  
  - Dit voorkomt ongeautoriseerd gebruik van de applicatie.  

- **Splitsen & hernoemen van PDF-loonstroken**  
  - Automatisch splitsen van een groot PDF-document in individuele bestanden.  
  - Bestanden worden hernoemd op basis van:
    - **ID** en **naam** (via regex uit PDF gehaald)  
    - Optioneel: extra informatie (bijvoorbeeld maand van de loonstrook).  

- **Medewerkersbeheer**  
  - Mogelijkheid om een lijst met medewerkers te beheren.  
  - Nodige gegevens:  
    - **Medewerker ID**  
    - **E-mailadres van medewerker**  

- **Versturen van loonstroken per mail**  
  - Automatisch verzenden van de juiste loonstrook naar de juiste medewerker.  
  - Optioneel: bepaalde medewerkers uitsluiten bij verzending.  

---

## 📌 Gebruik
1. Maak een account aan & verifieer met de ontvangen code.  
2. Log in met zakelijke mail (One.com, Gmail of Outlook).  
3. Upload het PDF-document met loonstroken.  
4. Laat de applicatie de bestanden splitsen en hernoemen.  
5. Beheer medewerkers (ID + e-mail).  
6. Verstuur alle loonstroken met één druk op de knop.  

---


