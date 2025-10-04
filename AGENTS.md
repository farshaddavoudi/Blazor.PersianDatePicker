# Repository Guidelines

## Project Structure & Module Organization
`Blazor.PersianDatePicker.sln` orchestrates the solution. The reusable component lives in `src/Blazor.PersianDatePicker/`, with Razor sources at the root and shared assets under `wwwroot/` (`datepicker.scss`, `datepicker.css`, `datepicker.min.js`). Sample apps in `samples/BlazorServer/` and `samples/BlazorWebAssembly/` show real-world integration; prefer the server sample for debugging so you can hot reload. Keep screenshots and marketing assets in the repository root beside the README.

## Build, Test, and Development Commands
- `dotnet restore Blazor.PersianDatePicker.sln` – hydrate NuGet dependencies across the solution.
- `dotnet build Blazor.PersianDatePicker.sln -c Release` – compile all projects and validate analyzers.
- `dotnet pack src/Blazor.PersianDatePicker/Blazor.PersianDatePicker.csproj -c Release -o artifacts` – produce the NuGet nupkg consumed by CI.
- `dotnet run --project samples/BlazorServer/BlazorServer.csproj` – launch the playground app for manual QA.
- `sass --style=compressed src/Blazor.PersianDatePicker/wwwroot/datepicker.scss src/Blazor.PersianDatePicker/wwwroot/datepicker.css` – rebuild the stylesheet when SCSS changes; commit both `.scss` and generated `.css`.

## Coding Style & Naming Conventions
Follow the repository’s C# conventions: four-space indentation, `nullable` context enabled, and `LangVersion` set to `latest`. Use PascalCase for public members and Razor component names, camelCase for locals, and `_camelCase` for private fields to match existing patterns. Keep Razor files structured as markup first and a single `@code` block last. Prefer expression-bodied members and guard clauses to keep methods short. Run `dotnet format` (or your IDE equivalent) before committing.

## Testing Guidelines
No dedicated test project exists yet; add new coverage under a future `tests/` directory with `*Tests.csproj` naming so CI discovers it automatically. Target xUnit or NUnit, and group tests by feature area. Until automated coverage lands, document manual verification in the PR by listing the sample pages exercised. Always execute `dotnet test` locally once tests are added, and include screenshots or logs when validating UI behaviour.

## Commit & Pull Request Guidelines
Commits follow short, imperative subjects (`Enhance version commit process`) and may append qualifiers like `[skip ci]` for documentation-only changes. Keep logical changes isolated and update `Blazor.PersianDatePicker.csproj`’s `<Version>` only when preparing a release branch or tag. For PRs, provide a concise summary, reference related issues with `Fixes #123`, attach before/after visuals for UI tweaks, and call out any SASS rebuilds or manual test steps. Ensure CI passes before requesting review.

## Packaging & Release Prep
Tagged releases (`v*.*.*`) trigger the GitHub Actions workflow that restores, builds, packs, and publishes the NuGet package. Before tagging, verify the generated CSS/JS artefacts, confirm the version bump, and inspect `artifacts/` locally with `ls artifacts` to ensure the `.nupkg` contains the updated README and assets.
