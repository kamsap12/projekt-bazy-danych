# System Biblioteczny - Dokumentacja Projektu

## 1. Opis projektu
Aplikacja webowa typu "Library System" stworzona w technologii ASP.NET Core MVC. Pozwala na kompleksowe zarządzanie katalogiem książek, bazą autorów oraz kategoriami literackimi.

## 2. Instalacja i uruchomienie
Aby poprawnie uruchomić projekt na nowym środowisku, wykonaj poniższe kroki:

1. **Kompilacja:** Otwórz plik `.sln` i zbuduj rozwiązanie skrótem `Ctrl + Shift + B`. Upewnij się, że operacja zakończyła się sukcesem (Kompilowanie: powiodło się).
2. **Przygotowanie bazy danych:** Otwórz **Package Manager Console** (Widok -> Inne okna) i wykonaj komendę:
   `Update-Database`
   *Spowoduje to utworzenie lokalnej bazy SQL Server (LocalDB) oraz wszystkich wymaganych tabel (Punkt 6b).*
3. **Uruchomienie aplikacji:** Użyj skrótu **`Ctrl + F5`** (Uruchom bez debugowania). Jest to zalecana metoda, która gwarantuje poprawne otwarcie strony głównej w przeglądarce pod adresem `localhost`.

## 3. Testowi Użytkownicy (Punkt 6c)
System posiada automatyczny mechanizm "seeding", który przy pierwszym uruchomieniu tworzy konto administratora:
* **Rola Admin:** `admin@biblioteka.pl` / **Hasło:** `Admin123!`
* **Rola Użytkownik:** Dowolne konto założone przez opcję "Register".

## 4. Opis działania (Perspektywa użytkownika)
1. **Gość:** Po wejściu na stronę główną widzi kafelki nawigacyjne. Może przeglądać listę książek, autorów i kategorii, ale nie widzi opcji edycji ani usuwania.
2. **Użytkownik zalogowany:** Posiada uprawnienia gościa oraz możliwość przeglądania szczegółów profilu.
3. **Administrator:** Po zalogowaniu na konto `admin@biblioteka.pl`, w menu "Książki", "Autorzy" i "Kategorie" pojawiają się dodatkowe przyciski: **Create New**, **Edit** oraz **Delete**. Administrator ma pełną kontrolę nad zasobami biblioteki.
4. **API:** Deweloperzy mogą pobrać listę książek w formacie JSON pod adresem `/api/BooksApi`.

## 5. Lista spełnionych wymagań technicznych
* **MVC & GitHub:** Projekt oparty o wzorzec MVC, umieszczony na GitHub z historią commitów (Punkt 1, 2, 3).
* **CRUD:** Formularze dla Książek, Autorów i Kategorii z walidacją (Punkt 6a).
* **Baza danych:** Relacje 1:N między książką a autorem/kategorią (Punkt 6b).
* **API:** Implementacja kontrolera API zwracającego dane JSON (Punkt 6d).
