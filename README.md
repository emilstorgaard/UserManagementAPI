# User Management API

Dette er User Management API.

APIet bruger basepath `[hostname]/api/`

## Projekt Opsætning

### Lokalt

1. **Klon Repositoriet**

    ```
    git clone https://github.com/emilstorgaard/UserManagementAPI.git
    ```

2. **change directory to the project folder**

    ```
    cd UserManagementAPI
    ```


3. **Init database**

    1. Hvis du vil køre projektet lokalt, skal du først udfylde `DefaultConnection` i appsettings med en MsSQL connection string.
    2. Nu skal du updatere din MsSQL med kommandoen`update-database`

### Docker

For at bygge og køre projektet ved hjælp af Docker, følg disse trin:

1. **Byg Docker Image**

    ```
    docker build -t user_management_api .
    ```

2. **Kør Containeren**

    ```
    docker run -p 8080:8080 user_management_api
    ```

    Herefter er applikationen tilgængelig på `localhost:8080`.

© Emil Storgaard Andersen, 2024.