### Hi There. Document for MicroServices

**Advantages of Microservices**:
(1) Small Projects could be Tested Easily.
(2) If a Small Service fails and fall (for example, Reports module) does not affect other modules, like Orders, Payments, Delivery.
(3) In a Microservices envoirnment, only one service can be Scalled. For example? On BlackFriday I can improve the ORDER module/microservice.

**Disavantages of Microservices**:
(1) If Modules depends to much on each-other, like ORDER depends on Product/Stock/Delivery/Client/Finances modules and they are separated in the architecture, you could have the problem of data-dependency, too many calls from one API to other to get data (in case of scenarios where DB is not shared and are also isolated).
(2) Harder to understand the Architecture of the System, will be harder to new members on the team.
(3) More repositories, more services in production, more number of monitoring of these services. More Admins to make it all RUN.