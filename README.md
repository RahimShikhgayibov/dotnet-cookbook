# \# dotnet-cookbook

# 

# !\[CI](https://github.com/RahimShikhgayibov/dotnet-cookbook/actions/workflows/ci.yml/badge.svg)

# 

# A hand-written .NET reference repository: core parts of the platform rebuilt from scratch

# to understand how they work, then used the real way, with tests and notes for every module.

# 

# \## Why

# 

# Most of my professional code has been written alongside AI tools. This repository is where

# I make sure I understand the fundamentals well enough to write them from a blank file,

# debug them when they break, and critically review code that AI generates.

# Depth over speed: one module at a time, each one fully understood before moving on.

# 

# \## How each module works

# 

# 1\. Read the official docs.

# 2\. Build a minimal version from scratch (for example, a tiny DI container).

# 3\. Use the real .NET API and compare.

# 4\. Break it on purpose and observe what happens.

# 5\. Write tests and a short README: what it is, why, when NOT to use it, and gotchas.

# 

# \## Rules

# 

# \- No AI-generated code in this repository. AI is used only for explanations and code review.

# \- Warnings are errors, and code style is enforced at build time.

# \- Every module has tests and a README.

# 

# \## Structure

# 

# \- `src/Cookbook.BuildingBlocks` — shared extensions and patterns

# \- `src/Cookbook.Api` — reference Web API where everything comes together

# \- `tests/Cookbook.Tests` — xUnit tests

# 

# \## Getting started

# 

# Requires the .NET 10 SDK.

# 

# ```bash

# dotnet build

# dotnet test

# ```

# 

# \## Progress

# 

# | Phase | Topic | Status |

# |---|---|---|

# | 0 | Setup: SDK pinning, solution, code style, CI | Done |

# | 1 | C# \& runtime: DI, LINQ, async | Next |

# | 2 | ASP.NET Core pipeline | Planned |

# | 3 | Data: ADO.NET, EF Core | Planned |

# | 4 | API design | Planned |

# | 5 | Auth \& security | Planned |

# | 6 | Background jobs, SignalR, caching | Planned |

# | 7 | Production: Docker, observability | Planned |

