# EventEase
A web application designed for event management, allowing users to browse events, view detailed information, register for events, and manage attendance. 

Built using Blazor WebAssembly

# Features
- **Event Discovery**: Browse a variety of events, each displaying key details like title, date, and venue.

- **Seamless Navigation**: Effortlessly move between event listings, detailed views, and sign-up pages.

- **User Registration**: Register securely through a form with built-in validation for fields like name and email.

- **Session Handling**: Manage user sessions to support consistent registration tracking.

- **Participant Logging**: Maintain a clear record of attendees to streamline event coordination.

- **Optimized Performance**: Handle extensive event listings efficiently using Blazor’s Virtualize component.

# Getting Started
### Prerequisites
- .NET SDK
- A modern web browser

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/rileydes/event-ease-demo.git
   cd EventEaseApp
   ```
2. Restore
   ```bash
   dotnet restore
   ```
3. Run the app:
   ```bash
   dotnet run
   ```
4. Access the app in your browser at `http://localhost:5055`.
    May be at a different port, look at the output of the dotnet run command


# How Copilot Assisted

## Activity 1 – Foundations

    Used Copilot to scaffold the EventCard component and routing pages.
    Leveraged code suggestions for basic data binding syntax and navigation paths.

## Activity 2 – Debugging & Optimization

    Copilot helped identify data validation issues in the EventCard.
    Suggested using <Virtualize> and @key for event list optimization.
    Added fallback logic for routing errors with Copilot-guided logic.

## Activity 3 – Advanced Features

    Copilot generated the form validation logic and EditForm structure.
    Suggested a pattern for static state tracking (UserSession class).
    Generated service-based attendance tracking model and DI setup.

## Outcome:

The app now includes:
    A fully validated registration form
    Session state and participation tracking
    Smooth routing and performance with large data
    A clean, production-ready codebase