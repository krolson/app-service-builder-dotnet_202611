# Product

<!-- impeccable:product-schema 1 -->

## Platform

web

## Users and purpose

Developers evaluating a minimal ASP.NET sample for App Service Builder. The
root showcase also supplies a recognizable visual for template thumbnails.

## Capabilities and constraints

The app uses .NET 10 without NuGet dependencies. `/` serves the workbench with
the cat illustration and "A cat today" caption; `/demo` redirects to `/`.
`/greeting` returns a public plain-text greeting, `/health` returns `OK`, and
unknown routes return 404. The app binds port 8080. Preserve these contracts,
`builder.yaml`, and the deployment workflow.
`SAMPLE_GREETING` is public and must never contain a secret.

The approved root page presents the actual greeting and existing runtime
facts. User-triggered request controls call only `/greeting` and `/health` and
display real responses or errors. There is no deployment telemetry or account backend.

## Brand commitments

The approved direction is a distinct, structured .NET workbench with plum
accents and refined neutral surfaces. Preserve factual sample content, use
responsive layouts, accessible contrast, and keyboard-operable controls.

## Evidence on hand

`Program.cs`, `builder.yaml`, and `README.md` establish the runtime and endpoint
behavior. Private Preview is for development and testing; local success does
not prove live deployment readiness.
