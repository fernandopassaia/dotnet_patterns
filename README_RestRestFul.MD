### Hi There. Starting now my knowledgments on REST and RESTFUK

First of all definition of **API**:
Application Programming Interface is a collection of rotines and patterns to other applications access this app. Is responsible to do communication between different services, a middleware between technologies, between exchange of information, 

**REST** is "Representational State Transfer" - a way to transfer data in a simbolic, figurative, representative and didatic way. Is basically the a way to put your resources available on Web. WebApi RESTS are based in Resources, they are stateless (all calls are auto-suficient, I'll send just once the request with all information, and receive just once the response with all information): So there's no SAFE or state on both sides, for example - if i need to send a request, every time I'll need also to send the TOKEN together. We use HTTP verbs (put, post, get, delete) to indicate actions. REST is exposed over URIs so the URL will tell you too much about what that specific service does.

REST is the definition: It's primary objective is to define fundamentals to construct WebApplications following good rules. Rest give you a collection of answers to the navigators, APIs and others that could know, in a good way, how to act to a determinated answer. Because REST has a table of answer (400, 401, 403, 404) the browsers and apps will know how to react to these answers. This code of status http could be defined in:

1xx - informative
2xx - success
3xx - redirecting
4xx - errors
5xx - errors on server

Example:
100 - Continue - Everything is all right, client can continue with request or ignore if finished what want to do.
200 - Success - Success on request
300 - 301 Moved Permantently - Indicates that the URI changed. Probably the new URI will be specified on asnwer, by this way, it's possible to acces the new url.
400 - Invalid Request - Bad Request - indicate that server does not understand the request because sintaxe is invalid.
500 - Internal error on Server - Server has an error and don't know how to deal with it.

**RESTFUL**: Be Restful is APPLY the REST Patterns. You have 6 patterns on REST methodologie, you're restful when you apply them all.

**6 Requirments/Patterns to be Restful**:

- _Client Server_: First of all you need the separation of concerns. You need clients like the Browser and Mobiles devices, and you need the Servers to store the Data, like the BackEnd. So first concept that it needs to follow is be a Client-Server architecture.

- _Stateless_: All the times i do a request, because it have no previous-state, it needs to go FULL. So I'll need to send the Token for example, each time, I'll need to inform the product, or the client, all the times i want to do the request. All REQUEST should contains ALL the information server needs to understand and answer (RESPONSE).

- _Cacheable_: The asnwers to a request, should be explict on say if THAT request could be cached or not by the client.

- _Layered System_: Client don't need to know how COMPLEX is the BackEnd

**The other 2 points are optional - so if you follow this 4 first principles, you are restful**

- _Code on demand (optional)_: Server could return to the client the possibility to take codes, like javascript, and execute it on client. Basically server will return CODE to the client.

- _Uniform Interface_: You need to create a Pattern to your resources. So you have to take a pattern to the URI (/client - /product), you have to take a pattern to the answer (server cannot answer in JSON sometimes, other times in XML, other in other formats) - your API should communicate in a pattern way.