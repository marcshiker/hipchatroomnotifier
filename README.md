HipChat Room Notifier
===================

A simple C# library for sending [HipChat](https://www.hipchat.com) room notifications. It's simple in that [HipChat's API](https://www.hipchat.com/docs/apiv2) is much more broad than just sending room notifications--I just chose to focus on this common need.

This repo also includes a Windows Console application for sending notifications through its command line.


HipChat Room Notifier
-----------------------------------



HipChat Room Notifier Console App
-----------------------------------

All command line parameters are required in the following order:

* **AuthToken** (get your token [here](https://www.hipchat.com/docs/apiv2/auth))
* **RoomName** (either the room name or id)
* **Color** (either 'yellow', 'green', 'red', 'purple', 'gray', or 'random')
* **Format** (either 'html' or 'text')
* **Notify** (either true or false)
* **Message**

For example:

~~~
yourauthtoken yourroomname green html false "hello from notifier con"
~~~
