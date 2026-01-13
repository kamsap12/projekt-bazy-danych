# System Biblioteczny - Dokumentacja Projektu

## 1. Opis projektu
Aplikacja webowa typu "Library System" stworzona w technologii ASP.NET Core MVC. Pozwala na kompleksowe zarz¹dzanie katalogiem ksi¹¿ek, baz¹ autorów oraz kategoriami literackimi.

## 2. Instalacja i Wymagania
* **Œrodowisko:** Visual Studio 2022 lub nowsze z zainstalowanym pakietem "ASP.NET i projektowanie stron internetowych".
* **Baza danych:** SQL Server (LocalDB).
* **Kompilacja:** Otwórz plik `.sln`, a nastêpnie u¿yj skrótu `Ctrl + Shift + B`, aby zbudowaæ projekt.

## 3. Konfiguracja
* **Po³¹czenie z baz¹ (Connection String):** Znajduje siê w pliku `appsettings.json`. Domyœlnie skonfigurowane dla `(localdb)\\mssqllocaldb`.
* **Migracje:** Przed pierwszym uruchomieniem nale¿y otworzyæ **Package Manager Console** i wykonaæ komendê:
  `Update-Database` - spowoduje to automatyczne utworzenie bazy danych oraz tabel (Punkt 6b).

## 4. Testowi U¿ytkownicy (Punkt 6c)
System posiada automatyczny mechanizm "seeding", który przy pierwszym uruchomieniu tworzy konto administratora:
* **Rola Admin:** `admin@biblioteka.pl` / **Has³o:** `Admin123!`
* **Rola U¿ytkownik:** Dowolne konto za³o¿one przez opcjê "Register".

## 5. Opis dzia³ania (Perspektywa u¿ytkownika)
1. **Goœæ:** Po wejœciu na stronê g³ówn¹ widzi kafelki nawigacyjne. Mo¿e przegl¹daæ listê ksi¹¿ek, autorów i kategorii, ale nie widzi opcji edycji ani usuwania.
2. **U¿ytkownik zalogowany:** Posiada uprawnienia goœcia oraz mo¿liwoœæ przegl¹dania szczegó³ów profilu.
3. **Administrator:** Po zalogowaniu na konto `admin@biblioteka.pl`, w menu "Ksi¹¿ki", "Autorzy" i "Kategorie" pojawiaj¹ siê dodatkowe przyciski: **Create New**, **Edit** oraz **Delete**. Administrator ma pe³n¹ kontrolê nad zasobami biblioteki.
4. **API:** Deweloperzy mog¹ pobraæ listê ksi¹¿ek w formacie JSON pod adresem `/api/BooksApi`.

## 6. Lista spe³nionych wymagañ technicznych
* **MVC & GitHub:** Projekt oparty o wzorzec MVC, umieszczony na GitHub z histori¹ commitów (Punkt 1, 2, 3).
* **CRUD:** Formularze dla Ksi¹¿ek, Autorów i Kategorii z walidacj¹ (Punkt 6a).
* **Baza danych:** Relacje 1:N miêdzy ksi¹¿k¹ a autorem/kategori¹ (Punkt 6b).
* **API:** Implementacja kontrolera API zwracaj¹cego dane JSON (Punkt 6d).