# Půjčovna knih

## Přehled

Aplikace "Půjčovna knih" je webová stránka napsaná v jazyce C# s využitím ASP.NET 8 MVC.
Nabízí následující funkcionality:

- Půjčení knihy
- Vrácení knihy
- Zobrazení počtu dní, které zbývají do vrácení knihy
- Upozornění na pozdní datum splatnosti
- Seznam autorů
- Seznam knih

Aplikace využívá databázové relace a dědění v rámci architektury MVC.
Pro úložiště dat je použit SQLite. Projekt byl vyvinut na macOS, ale obsahuje Dockerfile pro snadný deploy v kontejnerizovaném prostředí.

______________________________________________________________________

## Požadavky

- .NET SDK 8.0 nebo novější
- SQLite
- Docker (pro spuštění v kontejneru)

______________________________________________________________________

## Jak aplikaci spustit

### 1. Spuštění aplikace pro zobrazení za pomoci .NET CLI

1. Spusťte aplikaci:

   ```bash
   dotnet run
   ```

### 2. Spuštění aplikace pro vývoj pomocí .NET CLI

1. Naklonujte si tento repozitář

   ```bash
   git clone https://github.com/MirekNguyen/komponentova-tvorba.git
   cd komponentova-tvorba
   ```

2. Nainstalujte závislosti a ověřte integritu projektu:

   ```bash
   dotnet restore
   ```

3. Spusťte migrace, aby se nastavila databáze SQLite:

   ```bash
   dotnet ef database update
   ```

4. Spusťte aplikaci:

   ```bash
   dotnet run
   ```

5. Otevřete aplikaci v prohlížeči na adrese [http://localhost:5000](http://localhost:5000).

### 3. Spuštění pomocí Dockeru

1. Naklonujte si tento repozitář:

   ```bash
   git clone https://github.com/MirekNguyen/komponentova-tvorba.git
   cd komponentova-tvorba
   ```

2. Buildněte aplikace pomocí docker-compose:

   ```bash
   docker-compose up -d
   ```

3. Otevřete aplikaci v prohlížeči na adrese [http://localhost:8080](http://localhost:8080).

______________________________________________________________________

## Struktura projektu

- `Controllers` – Obsahuje controllery pro manipulaci s daty a zpracování HTTP požadavků.
- `Models` – Obsahuje datové modely včetně entit pro SQLite.
- `Views` – Obsahuje šablony pro zobrazení dat.
- `Data` – Obsahuje konfigurace databáze a migrace.
