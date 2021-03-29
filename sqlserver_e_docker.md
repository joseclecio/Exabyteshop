# SQL SERVER

Indicamos o uso do SQL Server através de contêiner. Aqui apresentaremos os comandos básicos para a instalação e execução de uma instância do Sql Server através do Docker


## Baixar a imagem do Sql Server 2019

`docker pull mcr.microsoft.com/mssql/server:2019-latest`

## Criar e executar o contêiner

`docker run -e ACCEPT_EULA=Y -e MSSQL_PID=Developer -e SA_PASSWORD=P@ssw0rd -p 1433:1433 --name=sql_server_docker -d mcr.microsoft.com/mssql/server:2019-latest`

- Substitua o `P@ssw0rd` por uma senha que contenha números, letras e caracteres especiais;
- Ajuste a porta (estou utilizando a porta padrão, 1433)

## Parar o contêiner:

`docker stop sql_server_docker`

## Iniciar o contêiner:

`docker start sql_server_docker`

# Saiba mais em

- https://hub.docker.com/_/microsoft-mssql-server
- https://github.com/gomex/docker-para-desenvolvedores
