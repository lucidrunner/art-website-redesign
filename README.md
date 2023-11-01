# art-website-redesign

Borde fungera just nu - uSync-pluginen används för att automatiskt spara alla ändringar och importera sparade ändringar när projektet startas om.

# Lite minnesanteckningar



# Installation
Klona ned repot  
  
Ladda ner https://drive.google.com/file/d/1EtBiV8rP-_7SythGLxQHxrcsL67MSE3R/view?usp=sharing och exportera i projektfoldern. Det måste finnas en umbraco/Data-folder med databas i root-foldern, uSync kommer importera senaste uppdateringarna ur repot på direkten in i databas-filerna.  
  
Första gången man öppnar sidan kan det hela krascha, bör fungera efter att uSync kört en gång. Att vänta typ 5 sekunder och ladda om bör lösa det.  

## Inloggningsuppgifter
admin@admin.se  
1password1  

# Steg för att återskapa grundprojektet
* Skapa nytt projekt via Umbraco-template
* Kör "dotnet add package Umbraco.TheStarterKit" och "dotnet add package uSync" för att lägga till Starter Kit och uSync
* Ta bort sektionen om att ignorera mediafoldern ur .gitignore
* Lägg till uSync-sektion i appsettings.json och ändra "ImportAtStartup" till "All"
  * uSync-settings går att hitta under Settings->Usync->Settings i Umbraco-dashboarden
* Zippa och skicka med startdatabasen separat.
