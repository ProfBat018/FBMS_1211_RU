# Тема урока. Volumes в Docker 

## Volume - это механизм для хранения данных вне контейнера.

То есть по факту это просто папка на хостовой машине, которая монтируется в контейнер.

Вы можете создать `volume` и использовать его в нескольких контейнерах. Например вы будете там хранить ассеты для веб-приложения, которые будут использоваться в нескольких контейнерах. Например `bootstrap`, `jquery` и т.д.

Также вы можете использовать `volume` для хранения данных, которые генерируются внутри контейнера. Например вы можете создать `volume` для базы данных, чтобы не потерять данные при перезапуске контейнера.

При создании `volume` вы можете указать путь, где он будет храниться на хостовой машине. Если не указать, то он будет создан в директории `/var/lib/docker/volumes/`.

При созднии `container` вы можете монтировать `volume` в контейнер. Для этого используется ключ `-v` или `--volume`. Первый параметр - это путь к `volume` на хостовой машине, второй - путь внутри контейнера, куда будет монтироваться `volume`.

Пример: `docker run -v /home/user/my-volume:/var/www/html -p 80:80 nginx`

## Создание volume

Создать `volume` можно с помощью команды `docker volume create`. Например: `docker volume create my-volume`

## Просмотр списка volume

Посмотреть список `volume` можно с помощью команды `docker volume ls`

## Удаление volume

Удалить `volume` можно с помощью команды `docker volume rm`. Например: `docker volume rm my-volume`

## Работа с volume в 




[Подробное про volume](https://docs.docker.com/storage/volumes/)

[Еще про volume](https://doka.guide/tools/docker-data-management/)
