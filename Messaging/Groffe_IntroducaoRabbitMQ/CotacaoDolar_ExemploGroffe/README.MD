https://hub.docker.com/_/rabbitmq
https://medium.com/@renato.groffe/net-core-mensageria-exemplos-utilizando-rabbitmq-e-azure-service-bus-66a81d02a731
https://github.com/renatogroffe/RabbitMQ-DotnetCore2-Selenium

Comando Docker:
docker run -d --hostname rabbit-local --name testes-rabbitmq -p 6672:5672 -p 15672:15672 -e RABBITMQ_DEFAULT_USER=testes -e RABBITMQ_DEFAULT_PASS=TESTES2020! rabbitmq:3.8.5-management-alpine