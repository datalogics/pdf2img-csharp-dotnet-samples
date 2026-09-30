# CLAUDE.md

See [README.md](README.md) for project usage and build guidance.

## Jira and release directories

Jira project: **[PDF2IMG](https://datalogics-jira.atlassian.net/browse/PDF2IMG)**.

PDF2IMG is the associated product Jira project; this sample-repo routing is inferred from the product association and should be confirmed if triage assigns a different owner. The directory is the parent product release tree, not a verified standalone sample destination. Do not copy sample artifacts there without confirming the release procedure.

Release paths below are relative to the shared `products/` directory:

| Artifact destination |
| --- |
| `pdf2img/<version>/` |

The same share is `/raid/products/` on Linux, `/Volumes/raid/products/`
on macOS, and `\\ivy\raid\products\` on Windows. Replace placeholders
with the release's actual version, package group, and platform directory names;
these are release-share names, not necessarily Conan profile names.

For release emails, verify that the candidate exists and include its complete
artifact path and filename. Preserve each product's directory layout;
do not invent a destination for an unverified release tree.
