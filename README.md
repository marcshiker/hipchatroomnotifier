HipChat Room Notifier
===================

A simple C# library for sending HipChat room notifications. It's simple in the fact that you can do much more with HipChat's API, I just chose to focus on a common taks, sending room notifications.

This repo also includes a Windows Console application for sending notifications using its command line.


HipChat Room Notifier
-----------------------------------



HipChat Room Notifier Console App
-----------------------------------

All command line parameters are required in the following order:

* AuthToken
* RoomName
* Color
* Format
* Notify
* Message

For example:

~~~
yourauthtoken yourroomname green html false "hello from notifier con"
~~~
