# Установка базового образа с .NET SDK и браузером
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS base

# Установка Selenium WebDriver
RUN apt-get update && apt-get install -y wget
RUN wget https://dl.google.com/linux/direct/google-chrome-stable_current_amd64.deb
RUN apt-get install -y ./google-chrome-stable_current_amd64.deb
RUN wget https://github.com/mozilla/geckodriver/releases/download/v0.30.0/geckodriver-v0.30.0-linux64.tar.gz
RUN tar -xzf geckodriver-v0.30.0-linux64.tar.gz -C /usr/local/bin/
RUN chmod +x /usr/local/bin/geckodriver

# Копирование файлов проекта
COPY . /app
WORKDIR /app

# Запуск тестов
CMD ["dotnet", "test"]
