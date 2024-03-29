# Тема урока. Введение в Kubernetes

## `Kubernetes` - это:
- Оркестратор контейнеров
- Отслеживает состояние кластера
- Запускает и останавливает контейнеры
- Масштабирует количество контейнеров
- Распределяет нагрузку между контейнерами
- Предоставляет сетевой доступ к контейнерам

## `Kubernetes` - это не:
- Средство автоматизации конфигурации
- Средство автоматизации развертывания
- Средство мониторинга
- Средство логирования

## Kubernetes - это средство для организации работы с контейнерами в кластере. По сути это расширение Docker Swarm, которое позволяет управлять несколькими Docker Swarm кластерами.

## Kubernetes состоит из следующих компонентов:
- Мастер-нода (Master Node)
- Рабочая нода (Worker Node)
- Под (Pod)
- Контроллер (Controller)
- Сервис (Service)
- Хранилище (Storage)

## `Мастер-нода (Master Node)` - это главный узел кластера, который отвечает за управление всеми ресурсами кластера. В состав мастер-ноды входят следующие компоненты:

## `Worker Node` - это рабочий узел кластера, который отвечает за запуск и остановку контейнеров. В состав рабочей ноды входят следующие компоненты:

## `Под (Pod)` - это минимальная единица развертывания в Kubernetes. Под представляет собой один или несколько контейнеров, которые разделяют один и тот же IP адрес, порт и файловую систему. Поды могут быть связаны с другими подами, например, для обеспечения доступа к базе данных.

## `Контроллер (Controller)` - это компонент, который отвечает за запуск и остановку подов. Контроллеры могут запускать и останавливать поды в зависимости от текущего состояния кластера. Например, контроллер может запускать новый под, если текущее количество подов меньше заданного количества.

## `Сервис (Service)` - это компонент, который отвечает за доступ к подам. Сервисы могут предоставлять доступ к подам по IP адресу и порту. Сервисы могут быть внутренними и внешними. Внутренние сервисы доступны только внутри кластера, а внешние сервисы доступны извне кластера.

## `Хранилище (Storage)` - это компонент, который отвечает за хранение данных. Хранилища могут быть различными, например, файловой системой, базой данных, кешем и т.д.

## Для работы с Kubernetes используется командная строка kubectl. Для установки kubectl воспользуйтесь инструкцией по ссылке: https://kubernetes.io/docs/tasks/tools/install-kubectl/

# Для работы с Kubernetes нам нужно будет: 
* Создать кластер
* Создать под
* Создать сервис
* Создать хранилище
* Создать контроллер

# Создание кластера
## Для создания кластера воспользуйтесь инструкцией по ссылке: https://kubernetes.io/docs/setup/production-environment/tools/kubeadm/create-cluster-kubeadm/

# Создание пода
## Для создания пода воспользуйтесь инструкцией по ссылке: https://kubernetes.io/docs/tasks/configure-pod-container/

# Создание сервиса
## Для создания сервиса воспользуйтесь инструкцией по ссылке: https://kubernetes.io/docs/tasks/access-application-cluster/service-access-application-cluster/

# Создание хранилища
## Для создания хранилища воспользуйтесь инструкцией по ссылке: https://kubernetes.io/docs/tasks/configure-pod-container/configure-persistent-volume-storage/

# Создание контроллера
## Для создания контроллера воспользуйтесь инструкцией по ссылке: https://kubernetes.io/docs/tasks/run-application/run-replicated-stateful-application/



