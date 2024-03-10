Databázový projekt (označení Core)


Úvod

Tento projekt slouží k připojení k vzdálené databáze skrze přihlašovací údaje. Je možné díky tomuto programu upravovat, 
přidávat či odstraňovat data v databázi. Případně naimportovat vlastní data díky JSON souboru. Databáze eviduje klienty
a jejich objednávky s produkty.


Prostředky

K připojení do databáze je použit konfigurační soubor App.config, ve kterém lze nalézt všechny potřebné informace 
včetně hesla a přihlašovacího jména. Tento soubor využívá třída DatabaseSingleton, která tvoří SQL připojení.
Pro přístup k datům jsem využil objekty tříd označených DAO (Data Access Objects), ty mají možnost úpravy, získání a 
vložení dat. Pro programování byl využit jazyk C# a stahnutelné nugget packages "Configuration Manager" a 
"Newtonsoft.Json".


Jak použít program?

Použití je velmi snadné, v základě je již konfigurační soubor správně vyplněn, takže není třeba dělat nic dalšího, než
zapnout aplikaci. Po zapnutí se objeví několik tlačítek po levé straně obrazovky, každé z nich umí otevřit příslušné
okno pro provedení požadované činnosti. Jakmile si uživatel rozklikne nějaké okno (klidně i víc najednou) může vyplnit
požadované údaje a stisknou tlačítko v daném poli pro provedení zápisu do databáze (či něčeho jiného). Následně se mu v 
okně výstupu, které je umístěno na dolní straně plochy objeví zpráva, zda vše proběhlo úspěšně.
Až bude chtít uživatel aplikaci ukončit, stačí mu stisknout červené tlačítko s "x" a program se okamžitě ukončí...


Téma

Databáze eviduje 5 tabulek --> Klient, Objednávka, Položka_objednávky, Produkt, Kategorie (produktu). Klient (Client) má 
unikátní uživatelské jméno (username) a email. Objednávka (Order) ví, ke kterému Klientovi patří a dále obsahuje číslo,
čas objednání, atd. Produkt je osazen názvem (tag) a cenou (price), ale také ví do jaké kategorie spadá. Kategorie 
má název (title) a nepovinnou poznámku (note). A v poslední řadě tabulka Položka_objednávky, ta slouží jako spojovník
mezi Produktem a Objednávkou, zkrátka eviduje produkty, které jsou na určité objednávce. 

