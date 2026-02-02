# Copilot Instructions

## General Guidelines
- Always follow best practices
- Always name variables meaningfully
- Always check the variables names in the existing codebase
- Ensure code is efficient and clean
- Avoid redundancy
- Write comments where necessary
- Ensure compatibility with .NET 10.0 and C# 14.0
- Adhere to project-specific coding standards
- Ensure proper error handling and logging
- Write unit tests for new functionalities
- Ensure code is maintainable and scalable 

## Code Style
- Use specific formatting rules
- Follow naming conventions

## Testing Instructions
- For unit tests, use the existing testing framework in the project
- Mock dependencies where applicable
- Ensure tests cover edge cases
- When interacting with `PopUpScreen` in tests, click its private `yesButton` control (via reflection and `PerformClick`) rather than setting `UserConfirmed` directly.