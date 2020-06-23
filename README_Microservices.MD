### Hi There. Document for MicroServices

**Advantages of Microservices**:
(1) Small Projects could be Tested Easily.
(2) If a Small Service fails and fall (for example, Reports module) does not affect other modules, like Orders, Payments, Delivery.
(3) In a Microservices envoirnment, only one service can be Scalled. For example? On BlackFriday I can improve the ORDER module/microservice.
(4) In a Monolitical app, your system goes bigger, bigger, bigger, bigger, and the maintanence will be each time harder when you have a big system with a lot of dependencies from things from all sides. A change on Client can broke Orders, can broke finances or something like that.
(5) Less coupling - greater cohesion (Menor acoplamento - maior coesão).

**Disavantages of Microservices**:
(1) If Modules depends to much on each-other, like ORDER depends on Product/Stock/Delivery/Client/Finances modules and they are separated in the architecture, you could have the problem of data-dependency, too many calls from one API to other to get data (in case of scenarios where DB is not shared and are also isolated).
(2) Harder to understand the Architecture of the System, will be harder to new members on the team.
(3) More repositories, more services in production, more number of monitoring of these services. More Admins to make it all RUN.

**Kind of Microservices:**
(1) RPC: Based on Requests and responses, more traditional way, server and client. Socket, HTTP, Rest, SOAP.
(2) Resource Sharing: I send a message to a DataBase, FileSystem or Message Broker (like RabbitMQ) and the Apps communicate using it.

**Message Broker:**
É um tipo de Resource sharing exclusivo para troca de mensagens. Possui features exclusivas pra aumentar resiliência, escalabilidade e confiabilidade.

Escalabilidade: Suporta centenas de milhares de consumidores e produtores, simultaneamente.
Entrega única: Uma mensagem, em uma fila, só é entregue a um consumidor.
Flexível: Oferece mecanismos de roteamento e distribuição.

No Universo do MB só existe: Publisher (quem envia a mensagem) e Consumer (quem lê, processa, recebe uma mensagem).
O Message Broker é um **mediador**! Veja as imagens na pasta Doc, tem bastante explicação e inclusive código de exemplo sobre como configurar. 

**Fila**:
Existem 3 tipos de Filas:
Durável: Sobrevive ao restart do message broker.
Exclusiva: Somente 1 consumidor e morre quando não há consumidores.
Auto Delete: Morre quando não há mais mensagens.

**Exchange**:
Papel dele é distribuição entre filas. Pra isso existem vários padrões e tipos de exchange.

Direct: Parte da convenção do routing key ou o nome da fila pra que a mensagem chegue na fila, esse é o padrão.
Bind: 