ZowieTek API v1.1 Documentation

This document outlines the commands that are available to all Zowietek devices, allowing users to

remotely interact with devices to automate and script control.

The API mainly uses POST commands to allow users to set parameters of Zowietek devices and view

current parameter settings.

Please ensure syntax and values are valid to ensure proper operation of Zowietek device.

The meaning of the status code of the return parameter is as follows.

Copyright © 2024 Zowietek Electronics, Ltd. All rights reserved.

API Terms of Use

Effective Date: [2024.1.1]

Welcome to the API services provided by Zowietek (hereinafter referred to as "we" or "our company").

Before using this API, please carefully read and agree to the following terms and conditions

(hereinafter referred to as "Terms").

1. Acceptance of Terms

1.1 By accessing or using this API, you agree to be bound by these Terms. If you do not agree to all or part of

these Terms, please do not use this API.

1.2 We reserve the right to modify these Terms at any time. The modified Terms will take effect immediately

upon being posted on our website. Your continued use of this API constitutes your acceptance of the modified

Terms.

2. API Usage

2.1 We grant you a limited, non-exclusive, non-transferable, revocable license to access and use this API in

accordance with these Terms.

2.2 You agree to use this API only for lawful purposes and to comply with all applicable laws, regulations, and

these Terms.

2.3 You shall not:

Reverse engineer, decompile, disassemble, or otherwise attempt to derive the source code of this API.

Modify, adapt, translate, or create derivative works of this API.

Rent, lease, lend, sell, distribute, or sublicense this API in any manner.

Use this API to develop any products or services that compete with this API.

Use this API for any illegal, fraudulent, defamatory, harassing, or otherwise inappropriate activities.

Interfere with or disrupt this API or its related servers or networks in any way.

3. Intellectual Property

3.1 This API and all its content, including but not limited to software, code, text, graphics, logos, icons, images,

audio clips, digital downloads, and data compilations, are protected by copyright, trademark, and other

intellectual property laws.

3.2 You may not use any of our trademarks, service marks, trade dress, or other proprietary information

without our express written permission.

4. Disclaimer

4.1 This API is provided "as is" without any express or implied warranties, including but not limited to

warranties of merchantability, fitness for a particular purpose, and non-infringement.

4.2 We do not guarantee that this API will be uninterrupted, timely, secure, or error-free.

4.3 Your use of this API is at your own risk.

5. Limitation of Liability

5.1 In no event shall we be liable for any direct, indirect, incidental, special, consequential, or punitive damages

arising from the use or inability to use this API, including but not limited to loss of profits, data loss, business

interruption, or other commercial damages, even if we have been advised of the possibility of such damages.

6. Termination

6.1 We may terminate or suspend your right to access and use this API at any time at our sole discretion, with

or without prior notice.

6.2 Upon termination, you must immediately cease using this API and destroy all materials obtained from it.

7.API Change

7.1  If a change results in API incompatibility or impacts existing functionality，we shall not be held liable for
any direct or indirect losses arising from such changes.

7.2 We reserve the right to modify, suspend, or terminate the API service at any time. We shall not be liable for

any losses (including but not limited to data loss, business interruption, or loss of profits) caused by API

changes, service interruptions, or termination.

8. Miscellaneous

8.1 These Terms constitute the entire agreement between you and us regarding this API and supersede all

prior or contemporaneous oral or written agreements, understandings, or communications between you and

us.

8.2 If any provision of these Terms is found to be invalid or unenforceable, that provision shall be severed or

modified to the extent necessary to make it enforceable, without affecting the remaining provisions.

8.3 These Terms shall be governed by and construed in accordance with the laws of the People's Republic of

China.

9. Contact Us

If you have any questions about these Terms or this API, please contact us at:

Zowietek Electronics, Ltd.

Support: support@zowietek.com

+86-21-50277371, 50277372

1. status

Value

000000

Description

The modification is successful

Value

00002

00003

00004

00005

00006

00007

00008

00009

00010

50001

50002

60001

60002

60003

60004

60005

60006

60007

60008

60009

60010

60011

60012

60013

70001

70002

70003

70004

Description

Program is not ready

Missing required parameters

Product not supported

Switch opening failed

Switch not open

Enable not open

Verification code error

The operation is too fast, please wait

Restarting, please wait

NDI activation failed

NDI has been activated and does not need to be activated again

Stream URL already exists

Failed to start streaming

Failed to close streaming

Invalid URL

Stream protocol is not supported

protocol mismatch

The stream is open and needs to be closed before operation

Invalid IP

Invalid port

Protocol selectId mismatch

The number of streams reaches the maximum value

Push type is not supported

Invalid index

Failed to connect to WiFi

Wrong IP address

IP address is occupied

The data is the same and no modification is required

Value

70005

70006

70007

70008

70009

70010

70011

70012

70013

70014

70015

70016

80001

80002

80003

80004

80005

80006

80007

80008

80009

90001

100001

100002

100003

100004

100005

100006

Description

Password length must be more than eight characters

Account cannot be empty

HTTP port is occupied

RTMP port is occupied

RTSP port is occupied

VISCA TCP port is occupied

VISCA UDP port is occupied

WebSocket port is occupied

RTP port is occupied

Onvif port is occupied

Onvif soap port is occupied

No WiFi module

User not found

User already exists

User is not logged in

Non-admin account

Wrong password

File format error

Upgrading firmware is illegal

Log saving was not turned off before clearing the logs.

Log reading failed

Please plug in the signal source before modifying the audio configuration

disk full

Invalid storage medium

Photo format is wrong

Photo format is wrong

Photo format is wrong

Uninstall failed

Value

100007

100008

100009

100010

100011

100012

100013

100014

100015

110001

110002

110003

110004

110005

110006

110007

110008

120001

120003

120004

120005

130001

130002

130003

130004

140001

140002

140003

Description

Disk not mounted

Mount failed

NAS service is busy

Disk information has reached the maximum limit

There is an open NAS device, please close it first

Modification is not allowed when open

NAS is not open

Format failed

Storage device is occupied

The task has been started and cannot be modified

Invalid index

Task name already exists

The mission has started. cannot be deleted

Task startup failed

Task exceeds maximum limit

Recording in progress and cannot be modified

Operating too fast

Maximum value reached

Startup failed

Close failed

The video module is not started and the layout cannot be started

No signal source

Not allowed to change output resolution

Quality out of range

Output loopout switching mode failed

Decoded URL already exists

Decoding address is full

Invalid decoding index

Value

140004

140005

140006

2. rsp

Description

Decoding type is not supported

Please close it before operating

Decoding startup failed

rsp is the explanation of status code. Different values will be displayed according to the interface and status

code. When an error occurs, the meaning of each status code can be obtained through the value of rsp.

API Terms of Use

1. Input/Output

Input signal detection

Output information settings

Get output information

2. PTZ camera control for ZowieBox

Get configuration information

Set configuration information

3. PTZ control

Camera pans left(one step)

Camera pans left(continuous)

Camera pan right(one step)

Camera pan right(continuous)

Camera tilta up(one step)

Camera tilts up (continuous)

Camera tilts down(one step)

Camera tilts down(continuous)

Specify horizontal position

Specify vertical position

Get focus mode

Set focus mode

Get autofocus sensitivity

Set autofocus sensitivity

Get focus area

Set focus area

Get focus speed

Set focus speed

Get AF Lock status

Set AF Lock status

Get digital zoom magnification

Set digital zoom magnification

Get zoom speed

Set zoom speed

Trigger one-push focus

Focus Far (one step)

Focus Near (one step)

Focus Far (Continuous)

Focus Near (Continuous)

Set Presets

Call Presets

Delete Presets

Delete Presets

4. Encoding

Get encoding parameters

Modify encoding parameters

5. Decoding

Add decoding URL

Get decoding information

Delete decoding URL

Modify decoding information

Get decoding status

6. NDI decoding

NDI find

Get NDI source

Enable NDI decoding

Disable NDI decoding

Getting NDI group information

Setting the NDI group

7. NDI

Active NDI

Get saved authorization code

Get NDI configuration parameters

Set NDI configuration parameters

NDI switch

8. Audio

Get audio configuration information

Set audio configuration information

Audio switch

9. Streaming

Publish stream information

Get stream information

Start/stop streaming

Delete stream information

Modify stream display order

10. AP

Get AP configuration information

Modify AP configuration information

AP switch

11. LAN

Get LAN data

Modify LAN configuration information

Check LAN connectivity

Detecting connectivity with the Internet

Get display IP

12. WIFI

WiFi switch

Get WiFi list

Get wifi connection information/status

Connect to WiFi

13. Port

Get port information

Set port information

14. mDNS

Get mDNS information

Set mDNS information

15. User Management

Obtain user information

Delete users

Add user

Modify user information

Log in

Log out

Verify account existence

16. Device time

Get device time

Set device time

17. Recording

Get storage device status

Get recording task list

Modify recording task information

Start/stop recording

Get the video file path

18 .Snapshot

Snapshot

Get the photo path

19 . Tally

Get Tally parameters

Set Tally parameters

Turn on/off Tally

Get Tally color

20 . Restore and reboot

Reboot

Restore Factory

Standby

Exit standby

21. Image Settings

Get exposure setting data

Modify exposure setting data

Get aperture value

Set aperture value

Get color setting data

Modify color setting data

Getting image setting data

Modify image setting data

Get noise reduction setting data

Modify noise reduction setting data

Get image style data

Modify image style data

Get AE Lock status

Set AE Lock status

22.Patient Case

Create Patient Information

Case Query

23.Pan/Tilt/Zoom/Focus Control

Pan/Tilt Control

Zoom Control

Go Home

Preset position settings

Preset position recall

Preset position deletion

Focus mode settings

Focus mode acquisition

Focus control (continuous)

24. Temperature

Get CPU temperature

25. Tally

Get Tally mode

Turn On/Off Tally

Set Tally parameters

Get the current color of Tally

1. Input/Output

Input signal detection

Signal input detection can directly detect the resolution of the input signal and the sampling rate of the audio.

Device Supported: ZowieBox

http://x.x.x.x/video?option=getinfo&login_check_flag=1

Body(example):

{

  "group": "hdmi",

  "opt": "get_input_info"

}

Response(example):

{

  "status": "00000",

  "rsp": "succeed",

  "data": {

    "hdmi_signal": 1,

    "audio_signal": 48000,

    "width": 1920,

    "height": 1080,

    "framerate": 60.0,

    "desc": "1080p60"

  }

Parameter

Value

Description

hdmi_signal

0/1

audio_signal

0/32000/44100/48000

width

height

framerate

desc

0: no HDMI signal

1: HDMI signal detected

0: no audio

32000: audio sample rate

44100: audio sample rate

48000: audio sample rate

signal resolution width

signal resolution height

signal frame rate

The resolution displayed on the web page

Output information settings

Output information settings can set the output resolution, output loop-out mode, and output mute.

Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/video?option=setinfo&login_check_flag=1

Body(example):

{

  "group": "hdmi",

  "opt": "set_output_info",

  "data": {

    "format": "2160p30",

    "audio_switch": 1,

    "loop_out_switch": 0

  }

}

Parameter

Value

Description

format

1080p50/1080p30/1080p25/1080p24/

Output resolution

2160p30/2160p25/2160p24/1080p60/

1080i60/1080i50/720p60/720p50

audio_switch

loop_out_switch

0/1

0/1

0:mute

1:unmute

Supported by ZowieBox

0:output

1:loop out

Response(example):

{

  "rsp": "succeed",

  "status": "00000"

}

Get output information

This interface can obtain information about the currently set output.

Device Supported: ZowieBox, ZowiePTZ, ZowieCam

http://x.x.x.x/video?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "hdmi",

    "opt": "get_output_info"

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed",

    "data": {

        "switch": 1,

        "vo_chnid": 0,

        "disp_dev": {

            "selected_id": 1,

            "disp_dev_list": [

                "LCD",

                "HDMI",

                "SDI"

            ]

        },

        "format": "2160p30",

        "audio_switch": 1,

        "loop_out_switch": 0,

        "bufnum": 0,

        "auto_follow": 0

    }

}

Parameter

Value

Description

2160p30/2160p25/2160p24/1080p60/

format

1080p50/1080p30/1080p25/1080p24/

Output resolution

1080i60/1080i50/720p60/720p50

audio_switch

loop_out_switch

0/1

0/1

0:mute

1:unmute

Supported by ZowieBox

0:output

1:loop out

2. PTZ camera control for ZowieBox

Get configuration information

Get configuration information to get all the configuration information about how to control the camera.

 Device Supported: ZowieBox

http://x.x.x.x/ptz?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt":"get_ptz_info"

}

Response(example):

{

    "rsp": "succeed",

    "status": "00000",

    "data": {

        "protocol": 1,

        "protocol_list": [

            {

                "index": 0,

                "lable": "AUTO"

            },

            {

                "index": 1,

                "lable": "VISCA over IP",

                "type": 0,

                "ip": "192.168.1.167",

                "port": 1259,

                "addr": 1,

                "addr_fix": 0

            },

            {

                "index": 2,

                "lable": "ONVIF",

                "ip": "192.168.1.10",

                "onvif_port": 1259,

                "soap_port": 1259

            },

            {

                "index": 3,

                "lable": "VISCA",

                "baudrate_id": 2,

                "addr": 1,

                "addr_fix": 0

            },

            {

                "index": 4,

                "lable": "PELOCO D",

                "baudrate_id": 2,

                "addr": 1

            },

            {

                "index": 5,

                "lable": "PELOCO P",

                "baudrate_id": 2,

                "addr": 0

            }

        ],

        "usb2serial": 0

    }

}

Parameter

Value

Description

The currently set protocol

0:auto;Can only be applied to ZowiePTZ

protocol

0 to 5

1:VISCA over IP

3:Visca

4:Peclo-D

5:Peclo-P

Transfer Protocol

0:TCP

1:UDP

0/1

x.x.x.x

The IP of the controlled camera

1025 to 65535

Transmission port number

1 to 7

0 to 255

Visca over IP/Visca:1 to 7

Peclo_D/P:0 to 255

type

ip

port

addr

Parameter

Value

Description

addr_fix

0/1

baudrate_id

0 to 4

Fixed address

0:On

1:Off

0:2400

1:4800

2:9600

3:11920

4:38400

usb2serial

0/1

0:USB serial port detected

1:USB serial port not detected

Set configuration information

You can set configuration information about controlling the camera for camera control.

 Device Supported: ZowieBox

http://x.x.x.x/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt":"set_ptz_info",

    "data":{

        "protocol":1,

        "type":1,

        "ip":"192.168.1.167",

        "baudrate_id":1,

        "port":1259,

        "addr":1,

        "addr_fix":0

    }

}

Parameter

Value

Description

0:auto;Can only be applied to ZowiePTZ

1:VISCA over I;Can only be applied to ZowieBox

protocol

1

3:Visca

4:Peclo-D

5:Peclo-P

type

0/1

0:TCP

1:UDP

Transfer Protocol,it takes effect when protocol is 1

Parameter

Value

Description

ip

x.x.x.x

It takes effect when protocol is 1

The IP of the controlled camera

It takes effect when protocol is 3 or 4 or 5

baudrate_id

0 to 4

0:2400

1:4800

2:9600

3:11920

4:38400

port

1025 to 65535

It takes effect when protocol is 1

Transmission port number

addr

1 to 7

0 to 255

Visca over IP/Visca:1 to 7

Peclo_D/P:0 to 255

addr_fix

0/1

Fixed address

0:On

1:Off

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

3. PTZ control

Camera pans left(one step)

Let the camera turn left one step according to video

Device Supported: ZowiePTZ

http://x.x.x.x/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "control",

    "opid":3

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Camera pans left(continuous)

Let the camera rotate continuously to the left according to video

Device Supported: ZowiePTZ

http://x.x.x.x/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "control",

    "opid":4

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Camera pan right(one step)

Let the camera turn right one step according to video

Device Supported: ZowiePTZ

http://x.x.x.x/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "control",

    "opid":1

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Camera pan right(continuous)

Let the camera rotate continuously to the right according to video

Device Supported: ZowiePTZ

http://x.x.x.x/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "control",

    "opid":2

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Camera tilta up(one step)

Let the camera turn to the up one step according to video

Device Supported: ZowiePTZ

http://x.x.x.x/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "control",

    "opid":7

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Camera tilts up (continuous)

Let the camera turn continuously to the up according to video

Device Supported: ZowiePTZ

http://x.x.x.x/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "control",

    "opid":8

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Camera tilts down(one step)

Let the camera turn to the down one step according to video

Device Supported: ZowiePTZ

http://x.x.x.x/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "control",

    "opid":9

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Camera tilts down(continuous)

Let the camera turn continuously to the down according to video

Device Supported: ZowiePTZ

http://x.x.x.x/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "control",

    "opid":10

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Specify horizontal position

Let the camera rotate to the specified horizontal position

Device Supported: ZowiePTZ

http://x.x.x.x/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "control",

    "opid": 5,

    "data":

    {

        "value": 8000

    }

}

Parameter

Value

Description

value

0 to 8000

Horizontal movement range

Response(example):

{   "status": "00000",

    "rsp": "succeed"

}

Specify vertical position

Let the camera rotate to the specified vertical position

Device Supported: ZowiePTZ

http://x.x.x.x/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "control",

    "opid": 11,

    "data":

    {

        "value": 1152

    }

}

Parameter

Value

Description

value

0 to 2100

Vertical moving range

Response(example):

{  "status": "00000",

    "rsp": "succeed"

}

Get focus mode

Device Supported: ZowiePTZ, ZowieCAM

http://xxx.xxx.xxx.xxx/ptz?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "get_focusmode"

}

Response(example):

{

    "rsp": "succeed",

    "status": "00000",

    "data": {

        "selected_id": 0,

        "focusmode_list": [

            "AUTO",

            "MANUAL",

            "ONE_PUSH"

        ]

    }

}

Parameter

Value

Description

selected_id

0/1/2

0: AUTO

1: MANUAL

2: ONE_PUSH

Set focus mode

Device Supported: ZowiePTZ, ZowieCAM

http://x.x.x.x/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "set_focus_mode",

    "data": {

        "focusmode": 0

    }

}

Parameter

Value

Description

focusmode

0/1/2

0: AUTO

1: MANUAL

2: ONE_PUSH

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Get autofocus sensitivity

Device Supported: ZowiePTZ, ZowieCAM

http://xxx.xxx.xxx.xxx/ptz?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "get_sensitivity"

}

Response(example):

{

    "rsp": "succeed",

    "status": "00000",

    "data": {

        "selected_id": 1,

        "sensitivity_list": [

            "high",

            "medium",

            "low",

            "ultra low"

        ]

    }

}

Parameter

Value

Description

selected_id

0/1/2/3

0: high

1: medium

2: low

3: ultra low

Set autofocus sensitivity

Device Supported: ZowiePTZ, ZowieCAM

http://xxx.xxx.xxx.xxx/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "set_sensitivity",

    "data": {

        "selected_id": 0

    }

}

Parameter

Value

Description

selected_id

0/1/2/3

0: high

1: medium

2: low

3: ultra low

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Get focus area

Device Supported: ZowiePTZ, ZowieCAM

http://xxx.xxx.xxx.xxx/ptz?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "get_focus_zone"

}

Response(example):

{

    "rsp": "succeed",

    "status": "00000",

    "data": {

        "selected_id": 1,

        "zone_list": [

            "top",

            "center",

            "bottom",

            "left",

            "right",

            "all",

            "point"

        ],

        "point": {

            "x_percent": 500,

            "y_percent": 500,

            "d_pixel": 100

        }

    }

}

Parameter

Value

Description

selected_id

0 to 6

0: top

1: center

2: bottom

3: left

4: right

5: all

6: point

point

Specific coordinates of the focus area

Set focus area

Device Supported: ZowiePTZ, ZowieCAM

http://192.168.1.132/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "set_focus_zone",

    "data": {

        "selected_id": 0,

        "point": {

            "x_percent": 500,

            "y_percent": 500,

            "d_pixel": 20

        }

    }

}

Parameter

Value

Description

selected_id

0 to 6

0: top

1: center

2: bottom

3: left

4: right

5: all

6: point

point

Specific coordinates when the focus area is a point

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Get focus speed

Device Supported: ZowiePTZ, ZowieCAM

http://xxx.xxx.xxx.xxx/ptz?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "get_focus_speed"

}

Response(example):

{

    "rsp": "succeed",

    "status": "00000",

    "data": {

        "focus": 3

    }

}

Parameter

Value

Description

focus

1 to 10

Current focus speed

Set focus speed

Device Supported: ZowiePTZ, ZowieCAM

http://xxx.xxx.xxx.xxx/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "set_focus_speed",

    "data": {

        "focus": 5,

        "save_flag":1

    }

}

Parameter

focus

save_flag

Value

1 to 10

0/1

Description

Set focus speed

0: unsaved

1: save

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Get AF Lock status

Device Supported: ZowiePTZ, ZowieCAM

http://xxx.xxx.xxx.xxx/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "get_af_lock_status"

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed",

    "data": {

        "af_lock_status": 0

    }

}

Parameter

Value

Description

af_lock_status

0/1

0: off

1: on

Set AF Lock status

Device Supported: ZowiePTZ, ZowieCAM

http://xxx.xxx.xxx.xxx/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "set_af_lock_status",

    "data": {

        "af_lock_status": 1

    }

}

Parameter

Value

Description

af_lock_status

0/1

0: off

1: on

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Get digital zoom magnification

Device Supported: ZowiePTZ, ZowieCAM

http://xxx.xxx.xxx.xxx/video?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "digital_zoom"

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed",

    "digital_zoom": 100,

    "digital_zoom_enable": 0,

    "digital_zoom_max": 1200

}

Parameter

Value

Description

digital_zoom

100 to 1200

Digital zoom magnification

digital_zoom_enable

0/1

0: off

1: on

digital_zoom_max

Digital zoom maximum magnification

Set digital zoom magnification

Device Supported: ZowiePTZ, ZowieCAM

http://xxx.xxx.xxx.xxx/video?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "digital_zoom",

    "digital_zoom": 110,

    "digital_zoom_enable": 1,

    "digital_zoom_max": 400

}

Parameter

Value

Description

digital_zoom

100 to 1200

Digital zoom magnification

Parameter

Value

Description

digital_zoom_enable

0/1

0: off

1: on

digital_zoom_max

Digital zoom maximum magnification

Response(example):

{

    "rsp": "succeed",

    "status": "00000"

}

Get zoom speed

Device Supported: ZowiePTZ, ZowieCAM

http://xxx.xxx.xxx.xxx/ptz?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "get_zoom_speed"

}

Response(example):

{

    "rsp": "succeed",

    "status": "00000",

    "data": {

        "zoom": 5

    }

}

Parameter

zoom

Value

1 to 10

Description

zoom speed

Set zoom speed

Device Supported: ZowiePTZ, ZowieCAM

http://xxx.xxx.xxx.xxx/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "set_zoom_speed",

    "data": {

        "zoom": 9 ,

        "save_flag":1

    }

}

Parameter

zoom

save_flag

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Value

1 to 10

0/1

Description

zoom speed

0: unsaved

1: save

Trigger one-push focus

This interface is only effective when the focus mode is one-push focus.

Device Supported: ZowiePTZ

http://x.x.x.x/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "control",

    "opid":25,

    "point": {

            "x_percent": 500,

            "y_percent": 500,

            "d_pixel": 20

    }

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Focus Far (one step)

This interface is only effective in manual focus mode

Device Supported: ZowiePTZ

http://x.x.x.x/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "control",

    "opid":21

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Focus Near (one step)

This interface is only effective in manual focus mode.

Device Supported: ZowiePTZ

http://x.x.x.x/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "control",

    "opid":19

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Focus Far (Continuous)

This interface is only effective in manual focus mode

Device Supported: ZowiePTZ

http://x.x.x.x/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "control",

    "opid":22

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Focus Near (Continuous)

This interface is only effective in manual focus mode.

Device Supported: ZowiePTZ

http://x.x.x.x/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "control",

    "opid":20

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Set Presets

Device Supported: ZowiePTZ

http://x.x.x.x/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "control",

    "opid":26,

    "data":{

        "id": 1,

        "desc": "20aa"

    }

}

Parameter

id

desc

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Value

0 to 254

Description

preset id

preset name

Call Presets

Device Supported: ZowiePTZ

http://x.x.x.x/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "control",

    "opid":29,

    "data":{

        "id":1

    }

}

Parameter

id

Value

0 to 254

Description

preset id

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Delete Presets

Device Supported: ZowiePTZ

http://x.x.x.x/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "control",

    "opid":29,

    "data":{

        "id":1

    }

}

Parameter

id

Value

0 to 254

Description

preset id

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Delete Presets

Device Supported: ZowiePTZ

http://x.x.x.x/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt": "control",

    "opid":28,

    "data":{

        "id":10,

        "desc": "update10"

    }

}

Parameter

id

Value

0 to 254

Description

preset id

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

4. Encoding

Get encoding parameters

Get encoding parameters can get all set encoding parameters.

Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/video?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "all"

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed",

    "all": {

        "resolution_list": [

            {

                "desc": "3840*2160",

                "width": 3840,

                "height": 2160

            },

            {

                "desc": "2560*1440",

                "width": 2560,

                "height": 1440

            },

            {

                "desc": "1920*1080",

                "width": 1920,

                "height": 1080

            },

            {

                "desc": "1280*720",

                "width": 1280,

                "height": 720

            },

            {

                "desc": "1080*1920",

                "width": 1080,

                "height": 1920

            },

            {

                "desc": "720*1280",

                "width": 720,

                "height": 1280

            },

            {

                "desc": "640*360",

                "width": 640,

                "height": 360

            },

            {

                "desc": "320*180",

                "width": 320,

                "height": 180

            }

        ],

        "output_list": [

            "2160p30",

            "2160p29.97",

            "2160p25",

            "2160p24",

            "1080p60",

            "1080p59.94",

            "1080p50",

            "1080p30",

            "1080i60",

            "1080i59.94",

            "1080p29.97",

            "1080p25",

            "1080p24",

            "1080i50",

            "720p60",

            "720p59.94",

            "720p50"

        ],

        "vi": [

            {

                "vi_devid": 0,

                "vi_chnid": [

                    0,

                    1,

                    2,

                    3

                ],

                "width": 1920,

                "height": 1080,

                "framerate": 60,

                "transform": 0,

                "stream_id": 0,

                "desc": "main + display + snapshot"

            },

            {

                "vi_devid": 1,

                "vi_chnid": [

                    0,

                    1,

                    2,

                    3

                ],

                "width": 640,

                "height": 360,

                "framerate": 60,

                "transform": 0,

                "stream_id": 1,

                "desc": "sub + auto focus"

            }

        ],

        "venc": [

            {

                "followVI": 0,

                "venc_chnid": 0,

                "codec": {

                    "selected_id": 0,

                    "codec_list": [

                        "H.264",

                        "H.265",

                        "MJPEG"

                    ]

                },

                "profile": {

                    "selected_id": 0,

                    "profile_list": [

                        "BP",

                        "MP",

                        "HP"

                    ]

                },

                "ratecontrol": {

                    "selected_id": 0,

                    "mode_list": [

                        "CBR",

                        "VBR"

                    ]

                },

                "bitrate": 5000000,

                "ndi_bitrate_pre": 50,

                "width": 1920,

                "height": 1080,

                "framerate": 30,

                "keyinterval": 50,

                "gop": 50,

                "MaxQP": 45,

                "MinQP": 20,

                "keyMinQP": 10,

                "QPlevel": 1,

                "rotate": {

                    "selected_id": 1,

                    "rotate_list": [

                        "0",

                        "90",

                        "180",

                        "270"

                    ]

                },

                "stream_id": 0,

                "desc": "main"

            },

            {

                "followVI": 0,

                "venc_chnid": 1,

                "codec": {

                    "selected_id": 0,

                    "codec_list": [

                        "H.264",

                        "H.265",

                        "MJPEG"

                    ]

                },

                "profile": {

                    "selected_id": 0,

                    "profile_list": [

                        "BP",

                        "MP",

                        "HP"

                    ]

                },

                "ratecontrol": {

                    "selected_id": 0,

                    "mode_list": [

                        "CBR",

                        "VBR"

                    ]

                },

                "bitrate": 2000000,

                "ndi_bitrate_pre": 100,

                "width": 640,

                "height": 360,

                "framerate": 30,

                "keyinterval": 60,

                "gop": 60,

                "MaxQP": 45,

                "MinQP": 20,

                "keyMinQP": 10,

                "QPlevel": 1,

                "rotate": {

                    "selected_id": 0,

                    "rotate_list": [

                        "0",

                        "90",

                        "180",

                        "270"

                    ]

                },

                "stream_id": 1,

                "desc": "sub"

            },

            {

                "followVI": 0,

                "venc_chnid": 2,

                "codec": {

                    "selected_id": 2,

                    "codec_list": [

                        "H.264",

                        "H.265",

                        "MJPEG"

                    ]

                },

                "profile": {

                    "selected_id": 1,

                    "profile_list": [

                        "BP",

                        "MP",

                        "HP"

                    ]

                },

                "ratecontrol": {

                    "selected_id": 0,

                    "mode_list": [

                        "CBR",

                        "VBR"

                    ]

                },

                "bitrate": 18000000,

                "ndi_bitrate_pre": 100,

                "width": 1920,

                "height": 1080,

                "framerate": 60,

                "keyinterval": 60,

                "gop": 60,

                "MaxQP": 45,

                "MinQP": 20,

                "keyMinQP": 10,

                "QPlevel": 10,

                "rotate": {

                    "selected_id": 0,

                    "rotate_list": [

                        "0",

                        "90",

                        "180",

                        "270"

                    ]

                },

                "stream_id": 2,

                "desc": "snapshot"

            }

        ],

        "vdec": [

            {

                "vdec_chnid": 0

            }

        ],

        "vo": [

            {

                "switch": 1,

                "vo_chnid": 0,

                "disp_dev": {

                    "selected_id": 1,

                    "disp_dev_list": [

                        "LCD",

                        "HDMI",

                        "SDI"

                    ]

                },

                "format": "2160p30",

                "audio_switch": 1,

                "loop_out_switch": 1,

                "bufnum": 0,

                "auto_follow": 0

            }

        ]

    }

}

Parameter

Value

Description

codec.selected_id

0/1

profile.selected_id

0/1/2

ratecontrol.selected_id

0/1

0:264

1:265

0:BP

1:MP

2:HP

0:CBR

1:VBR

bitrate

64 to 51200

ndi_bitrate_pre

50 to 125

Main stream supports 64 to 51200

Sub stream supports 64 to 25600

When the device is in NDI mode, set the NDI

percentage code rate

width

3840/1920/1280/720

Resolution width, please keep it corresponding to

height

height

2160/1080/1980/1280

Resolution height, please keep it corresponding to

width

framerate

60/50/30/25/15

Encoding frame rate

keyinterval

20 to 240

I frame interval

rotate.selected_id

0/1/2/3

stream_id

0/1

clockwise rotation angle

0:0

1:90

2:180

3:270

0:main stream

1:sub stream

Modify encoding parameters

Modifying encoding parameters can modify various data such as encoding resolution, frame rate, code rate,

etc.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/video?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "venc",

    "venc": [

            {

                "venc_chnid": 0,

                "codec": {

                    "selected_id": 0,

                    "codec_list": [

                        "H.264",

                        "H.265",

                        "MJPEG"

                    ]

                },

                "profile": {

                    "selected_id": 0,

                    "profile_list": [

                        "BP",

                        "MP",

                        "HP"

                    ]

                },

                "ratecontrol": {

                    "selected_id": 0,

                    "mode_list": [

                        "CBR",

                        "VBR"

                    ]

                },

                "bitrate": 5000000,

                "ndi_bitrate_pre": 50,

                "width": 1920,

                "height": 1080,

                "framerate": 30,

                "gop": 60,

                "MaxQP": 69,

                "MinQP": 40,

                "keyinterval": 60,

                "keyMinQP": 10,

                "QPlevel": 1,

                "rotate": {

                    "selected_id": 0,

                    "rotate_list": [

                        "0",

                        "90",

                        "180",

                        "270"

                    ]

                },

                "stream_id": 0,

                "desc": "main"

            },

            {

                "venc_chnid": 1,

                "codec": {

                    "selected_id": 0,

                    "codec_list": [

                        "H.264",

                        "H.265",

                        "MJPEG"

                    ]

                },

                "profile": {

                    "selected_id": 0,

                    "profile_list": [

                        "BP",

                        "MP",

                        "HP"

                    ]

                },

                "ratecontrol": {

                    "selected_id": 0,

                    "mode_list": [

                        "CBR",

                        "VBR"

                    ]

                },

                "bitrate": 2000000,

                "ndi_bitrate_pre": 100,

                "width": 1280,

                "height": 720,

                "framerate": 30,

                "gop": 60,

                "MaxQP": 69,

                "MinQP": 20,

                "keyinterval": 60,

                "keyMinQP": 10,

                "QPlevel": 1,

                "rotate": {

                    "selected_id": 0,

                    "rotate_list": [

                        "0",

                        "90",

                        "180",

                        "270"

                    ]

                },

                "stream_id": 1,

                "desc": "sub"

            },

            {

                "venc_chnid": 2,

                "codec": {

                    "selected_id": 2,

                    "codec_list": [

                        "H.264",

                        "H.265",

                        "MJPEG"

                    ]

                },

                "profile": {

                    "selected_id": 0,

                    "profile_list": [

                        "BP",

                        "MP",

                        "HP"

                    ]

                },

                "ratecontrol": {

                    "selected_id": 0,

                    "mode_list": [

                        "CBR",

                        "VBR"

                    ]

                },

                "bitrate": 8000000,

                "ndi_bitrate_pre": 100,

                "width": 3840,

                "height": 2160,

                "framerate": 1,

                "gop": 60,

                "MaxQP": 69,

                "MinQP": 40,

                "keyinterval": 60,

                "keyMinQP": 10,

                "QPlevel": 1,

                "rotate": {

                    "selected_id": 0,

                    "rotate_list": [

                        "0",

                        "90",

                        "180",

                        "270"

                    ]

                },

                "stream_id": 2,

                "desc": "snapshot"

            }

        ]

}

Parameter

Value

Description

codec.selected_id

0/1

profile.selected_id

0/1/2

ratecontrol.selected_id

0/1

bitrate

64 to 51200

ndi_bitrate_pre

50 to 125

width

3840/1920/1280/720

height

2160/1080/1980/1280

0:264

1:265

0:BP

1:MP

2:HP

0:CBR

1:VBR

Main stream supports 64 to 51200

Sub stream supports 64 to 25600

When the device is in NDI mode, set the NDI

percentage code rate

Resolution width, please keep it corresponding to

height

Resolution height, please keep it corresponding to

weight

framerate

60/50/30/25/15

Encoding frame rate

keyinterval

20 to 240

I frame interval

clockwise rotation angle

0:0

1:90

2:180

3:270

0:main stream

1:sub stream

rotate.selected_id

0/1/2/3

stream_id

0/1

Response(example):

{

    "rsp": "succeed",

    "status": "00000"

}

5. Decoding

Add decoding URL

Enter the decoding URL of the RTSP, SRT, or RTMP protocol and use this URL for decoding.

 Device Supported: ZowieBox

http://x.x.x.x/streamplay?option=setinfo&login_check_flag=1

Body(example):

{

"group": "streamplay",

"opt": "streamplay_add",

"data":{

    "switch":0,

    "name": "test",

    "streamtype":0,

    "url": "rtsp://192.168.1.164/live/av012"

}

}

Parameter

Value

Description

switch

0/1

0:off

1:on

name

URL alias

streamtype

0/1

0:local

1:live

Display streams in different categories based on different streamtypes

url

Decoding URL

Response(example):

{

    "rsp": "success",

    "status": "00000"

}

Get decoding information

Get information of state, index, decoding URLs and etc.

 Device Supported: ZowieBox

http://x.x.x.x/streamplay?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "streamplay",

    "opt": "streamplay_get_all"

}

Response(example):

{

    "rsp": "succeed",

    "status": "00000",

    "streamplay": [

        {

            "index": 0,

            "switch": 0,

            "name": "111",

            "streamtype": 0,

            "url": "rtsp://192.168.1.205/1",

            "streamplay_status": 0,

            "bandwidth": 0,

            "framerate": 0.0,

            "width": 0,

            "height": 0

        },

        {

            "index": 1,

            "switch": 0,

            "name": "22",

            "streamtype": 1,

            "url": "rtmp://live.livevbond.com/test4/zowietek?auth_key=1629073289-0-0-

d9bb438e37df25c2a008c739cfaacc9c",

            "streamplay_status": 0,

            "bandwidth": 0,

            "framerate": 0.0,

            "width": 0,

            "height": 0

        },

        {

            "index": 2,

            "switch": 0,

            "name": "lalala",

            "streamtype": 0,

            "url": "rtsp://192.168.1.164/live/av012",

            "streamplay_status": 0,

            "bandwidth": 0,

            "framerate": 0.0,

            "width": 0,

            "height": 0

        }

    ]

}

Parameter

Value

Description

index

Open/close decoding URL or delete decoding URL based on index

switch

0/1

name

streamtype

0:off

1:on

URL alias

0:local

1:live

Display streams in different categories based on different streamtypes

url

Decoding URL

0:Not turned on

1:Pulling stream

2:Pulling stream stopped

streamplay_status

0 to 6

3:Pulling stream (no video)

4:Pulling stream (video format unsupported)

5:Pulling stream (no audio)

6:Pulling stream (audio format unsupported)

bandwidth

framerate

width

height

Bitrate of decoding

Frame rate of decoding

Video width of decoding

Video height of decoding

Delete decoding URL

Remove the corresponding decoded URL.

 Device Supported: ZowieBox

http://x.x.x.x/streamplay?option=setinfo&login_check_flag=1

Body(example):

{

"group": "streamplay",

"opt": "streamplay_del",

"data":{

    "index":0

}

}

Parameter

Value

Description

The index of the decoding URL, which can be obtained using the API for getting

decoding information

index

Response(example):

{

    "rsp": "success",

    "status": "00000"

}

Modify decoding information

Use this interface to modify the state, alias, URL, and other information of the decoding URL.

 Device Supported: ZowieBox

http://x.x.x.x/streamplay?option=setinfo&login_check_flag=1

Body(example):

{

"group": "streamplay",

"opt": "streamplay_modify",

"data":{

    "index":5,

    "switch":0,

    "name": "",

    "streamtype":0,

    "url": "rtsp://192.168.1.164/live/av012"

}

}

Parameter

Value

Description

index

The index of the decoding URL, which can be obtained using the API for getting

all decoding URL information

switch

0/1

0:off

1:on

name

URL alias

streamtype

0/1

0:local

1:live

Display streams in different categories based on different streamtypes

url

Decoding URL

Response(example):

{

    "rsp": "success",

    "status": "00000"

}

Get decoding status

Get whether decoding streaming is enabled.

 Device Supported: ZowieBox

http://x.x.x.x/streamplay?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "streamplay",

    "opt": "get_decoder_state"

}

Response(example):

{

    "rsp": "succeed",

    "status": "00000",

    "data": {

        "decoder_state": 0

    }

}

Parameter

Value

Description

decoder_state

0/1

0:No decoding streaming is enabled

1:With decoding streaming on

6. NDI decoding

NDI find

Search for all discoverable NDI sources currently on the LAN and use with the next interface to obtain NDI

sources on the LAN.

 Device Supported: ZowieBox

http://x.x.x.x/streamplay?option=setinfo&login_check_flag=1

Body(example):

{

  "group": "streamplay_ndi",

  "opt": "ndi_find"

}

Response(example):

{

    "rsp": "succeed!!!",

    "status": "00000"

}

Get NDI source

Obtain all searched NDI source information. Before using this interface to obtain NDI source, please use the

previous NDI find interface to ensure that the obtained NDI source information is the latest.

 Device Supported: ZowieBox

http://x.x.x.x/streamplay?option=getinfo&login_check_flag=1

Body(example):

{

  "group": "streamplay_ndi",

  "opt": "ndi_get_all"

}

Response(example):

{

    "rsp": "succeed!!!",

    "status": "00000",

    "data": [

        {

            "index": 0,

            "name": "HD CAMERA (NDI HB HX,192.168.1.205)",

            "url": "192.168.1.205:5961",

            "streamplay_status": 0,

            "bandwidth": 0,

            "framerate": 0,

            "width": 0,

            "height": 0

        },

        {

            "index": 1,

            "name": "NDI_HX (NDI-901233)",

            "url": "192.168.1.233:5961",

            "streamplay_status": 0,

            "bandwidth": 0,

            "framerate": 0,

            "width": 0,

            "height": 0

        }

    ]

}

Parameter

Value

Description

index

name

url

NDI decoding index

NDI name

NDI URL

0:Not turned on

1:Pulling stream

2:Pulling stream stopped

streamplay_status

0 to 6

3:Pulling stream (no video)

4:Pulling stream (video format unsupported)

5:Pulling stream (no audio)

6:Pulling stream (audio format unsupported)

bandwidth

framerate

width

height

Bitrate of decoding

Frame rate of decoding

Video width of decoding

Video height of decoding

Enable NDI decoding

Open NDI decoding according to the name of the NDI source. It is recommended that only one decoding be

enabled at the same time.

 Device Supported: ZowieBox

http://x.x.x.x/streamplay?option=setinfo&login_check_flag=1

Body(example):

{

  "group": "streamplay_ndi",

  "opt": "ndi_recv",

  "data": {

    "ndi_name": "HD CAMERA (NDI HB HX,192.168.1.205)"

  }

}

Parameter

Value

Description

ndi_name

Response(example):

Please enter the name of the NDI source correctly to open the NDI decoding.

Open up to one decoding streaming

{

    "rsp": "succeed!!!",

    "status": "00000"

}

Disable NDI decoding

Turn off the NDI decoding streaming.

 Device Supported: ZowieBox

http://x.x.x.x/streamplay?option=setinfo&login_check_flag=1

Body(example):

{

  "group": "streamplay_ndi",

  "opt": "ndi_close"

}

Response(example):

{

    "rsp": "succeed!!!",

    "status": "00000"

}

Getting NDI group information

Query the group of NDI in the decoded state of zowieBox

Device Supported: ZowieBox

http://x.x.x.x/streamplay?option=getinfo&login_check_flag=1

Body(example):

{

  "group": "streamplay_ndi",

  "opt": "ndi_get_recv_config"

}

Response(example):

{

    "rsp": "succeed!!!",

    "status": "00000",

    "data": {

        "groups": "Public"

    }

}

Parameter

Value

Description

groups

The NDI group in ZowieBox decoding mode

Setting the NDI group

Setting the NDI group in decoder mode.

Device Supported: ZowieBox

http://x.x.x.x/streamplay?option=setinfo&login_check_flag=1

Body(example):

{

  "group": "streamplay_ndi",

  "opt": "ndi_set_recv_config",

  "data": {

    "groups": "Public"

  }

}

Parameter

Value

Description

groups

The NDI group in ZowieBox decoding mode

Response(example):

{

    "rsp": "succeed!!!",

    "status": "00000"

}

7. NDI

Active NDI

After NDI is authorized and activated, the device can use NDI-related functions, including NDI encoding and

decoding.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/video?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ndi",

    "opt":"ndi_activate",

    "data":

    {

"license_key":"SW50aGJtVnRPaUp2SW1sYWRIZHJaVVZsWlNCMGJHOWphWEp6alpDQXVkQ3dpYVNJaVpDSTZPRzFPT

W1SQldIZElOMHA0UkdWUMVdObWgwTlcwNVRVOWhTR3BRYW5Ga04zWk5hRWR1V2taM2N6MHNJbTBpWTJFNklqQWlOVEty

ujtyE2T21ZNE1qYzZPbVl4TUdNeE9pd2lVeUlpVGlJNk1USXdNQ0kzZlE9PQ=="

    }

}

Parameter

license_key

Value

Description

NDI activation code

Response(example):

{

    "rsp": "success",

    "status": "00000"

}

Get saved authorization code

Obtain the NDI activation code after successfully activating NDI.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/video?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ndi",

    "opt":"get_license_key"

}

Response(example):

{

    "rsp": "succeed",

    "status": "00000",

    "data": {

        "license_key": "",

        "factory_activate": 1

    }

}

Parameter

Value

Description

license_key

You can obtain the NDI activation code that activates NDI after leaving the

factory.

factory_activate

0/1

0:Not activated before leaving the factory

1:Activated before shipment

Get NDI configuration parameters

Get NDI device name, group, multicast, quality and other information.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/video?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "ndi",

    "opt":"get_ndi_info"

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed",

    "data": {

        "activate": 1,

        "switch": 0,

        "mode_id": 3,

        "machinename": "ZowieBox-12343",

        "groups": "Public",

        "multicast": {

            "ttl": 1,

            "enable": 0,

            "netmask": "255.255.0.0",

            "netprefix": "239.255.0.0"

        }

    }

}

Parameter

Value

Description

activate

switch

0/1

0/1

mode_id

1/2/3

0:inactivated

1:activated

0:NDI off

1:NDI on

1:NDI|HX

2:NDI|HX2

3:NDI|HX3

NDI device name

NDI group

1 to 5

NDI multicast TTL

0/1

x.x.x.x

x.x.x.x

0:Multicast off

1:Multicast on

Multicast IP

Subnet Mask

machinename

groups

ttl

enable

netmask

netprifix

Set NDI configuration parameters

Set NDI device name, group, multicast, quality and other information.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/video?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ndi",

    "opt":"set_ndi_info",

    "data":

    {

        "switch":1,

        "mode_id":0,

        "machinename":"Zowietek-12343",

        "groups":"Public,A",

        "multicast":

        {

            "enable":1,

            "netmask": "255.255.0.0",

            "netprefix": "239.255.0.0",

            "ttl":1

        }

    }

}

Parameter

Value

Description

0/1

1/2/3

0:NDI off

1:NDI on

1:NDI|HX

2:NDI|HX2

3:NDI|HX3

NDI device name

NDI group

1 to 5

NDI multicast TTL

0/1

x.x.x.x

x.x.x.x

0:Multicast off

1:Multicast on

Multicast IP

Subnet Mask

switch

mode_id

machinename

groups

ttl

enable

netmask

netprifix

Response(example):

{

    "rsp": "succeed",

    "status": "000000"

}

NDI switch

NDI switch

Turn on or off NDI encoding function

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/video?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ndi",

    "opt":"ndi_switch",

    "data":

    {

        "switch":1

    }

}

Parameter

Value

Description

switch

0/1

0:NDI off

1:NDI on

Response(example):

{

    "rsp": "succeed",

    "status": "000000"

}

Get audio configuration information

8. Audio

Get all information about audio settings, including audio format, sampling rate, audio source, bit rate and

other information.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/audio?option=getinfo&login_check_flag=1

Body(example):

{

  "group": "all"

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed",

    "all": {

        "switch": 1,

        "ai_devid": 0,

        "ai_chnid": [

            0,

            1,

            2

        ],

        "ai_type": {

            "selected_id": 2,

            "ai_type_list": [

                "LINE IN",

                "Internal MIC",

                "HDMI IN"

            ]

        },

        "adec_chnid": 0,

        "aenc_chnnum": 1,

        "stream_id": [

            0,

            1,

            2

        ],

        "aenc_chnid": [

            0,

            1

        ],

        "ao_devnum": 2,

        "ao_devid": [

            0,

            1

        ],

        "ao_chnid": [

            0,

            0

        ],

        "ao_devtype": [

            1,

            0

        ],

        "codec": {

            "selected_id": 0,

            "codec_list": [

                "AAC",

                "MP3",

                "G.711A"

            ]

        },

        "bitrate": {

            "selected_id": 4,

            "bitrate_list": [

                32000,

                48000,

                64000,

                96000,

                128000

            ]

        },

        "sample_rate": {

            "selected_id": 4,

            "sample_rate_list": [

                8000,

                16000,

                32000,

                44100,

                48000

            ]

        },

        "bit_width": 16,

        "channel": 2,

        "volume": 100

    }

}

Parameter

Value

Description

switch

0/1

0:Audio off

1:Audio on

0:Line In

ai_type.selected_id

0/1/2

1:Internal MIC;supported by ZowieCam,ZowiePTZ

2:HDMI IN;support by ZowieBox

codec.selected_id

0/1/2

0:AAC

1:MP3

2:G.711A;Not currently supported

bitrate.selected_id

0/1/2/3/4

Audio bitrate

0:32000

1:48000

2:64000

3:96000

4:128000

Parameter

Value

Description

sample_rate.selected_id

0/1/2/3/4

Audio sample rate

0:8000

1:16000

2:32000

3:44100

4:48000

bit_width

16

Number of sampling digits, fixed value, please do not modify it

channel

1/2

Audio channel

1:Mono

2:Stereo

volume

0 to 100

Sound volume

Set audio configuration information

Set all information about audio settings, including audio format, sampling rate, audio source, bit rate and other

information.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/audio?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "audio",

    "audio": {

        "stream_id": 0,

        "ai_devid": 0,

        "ai_chnid": [

            0,

            1

        ],

        "adec_chnid": 0,

        "aenc_chnid": 0,

        "ai_type": {

            "selected_id": 0,

            "ai_type_list": [

                "LINE IN",

                "Internal MIC" ,

                "HDMI IN"

            ]

        },

        "ao_devid": 0,

        "ao_chnid": 0,

        "ao_devtype": {

            "selected_id": 1,

            "ao_devtype_list": [

                "LINEOUT",

                "HDMI"

            ]

        },

        "switch": 0,

        "codec": {

            "selected_id": 0,

            "codec_list": [

                "AAC",

                "MP3",

                "G.711A"

            ]

        },

        "bitrate": {

            "selected_id": 0,

            "bitrate_list": [

                32000,

                48000,

                64000,

                96000,

                128000

            ]

        },

        "sample_rate": {

            "selected_id": 3,

            "sample_rate_list": [

                8000,

                16000,

                32000,

                44100,

                48000

            ]

        },

        "bit_width": 16,

        "channel": 2,

        "volume": 2

    }

}

Parameter

Value

Description

0:Line In

ai_type.selected_id

0/1

1:Internal MIC ;Supported by ZowiePTZ and ZowieCam

2:HDMI ;suppported by ZowieBox

switch

0/1

codec.selected_id

0/1/2

0:Audio off

1:Audio on

0:AAC

1:MP3

2:G.711A;Not currently supported

Parameter

Value

Description

bitrate.selected_id

0/1/2/3/4

sample_rate.selected_id

0/1/2/3/4

Audio bitrate

0:32000

1:48000

2:64000

3:96000

4:128000

Audio sample rate

0:8000

1:16000

2:32000

3:44100

4:48000

bit_width

16

Number of sampling digits, fixed value, please do not modify it

channel

1/2

Audio channel

1:Mono

2:Stereo

volume

0 to 100

Sound volume

Response(example):

{

    "rsp": "succeed",

    "status": "00000"

}

Audio switch

Turn audio on or off.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/audio?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "audio_switch",

    "switch": 1

}

Parameter

Value

Description

switch

0/1

0:Audio off

1:Audio on

Response(example):

{

    "rsp": "succeed",

    "status": "00000"

}

9. Streaming

Publish stream information

Publishing stream information saves stream information settings to the device.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/stream?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "publish",

    "opt": "add_publish_info",

    "data": {

        "service":"custom",

        "protocol": "RTMP",

        "url": "rtmp://127.0.0.1/live/4",

        "key":"111",

        "switch": 1,

        "desc": "youtube",

        "name":"youtube"

    }

}

Parameter

Value

Description

protocol

RTMP/SRT

stream protocol

url

key

desc

name

stream url

stream key

Make notes about the stream information

The name of the stream displayed on the web page

Response(example):

{

    "rsp": "succeed",

    "status": "00000"

}

Get stream information

Call this interface to obtain the stream index, push address, push name, push key and other information.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/stream?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "getStreamStatus"

}

Response(example):

{

    "rsp": "succeed",

    "status": "00000",

    "publish_status": [

        {

            "switch": 0,

            "index": 1,

            "show_index": 1,

            "protocol": "RTMP",

            "venctype": 0,

            "aenctype": 0,

            "stream_id": 0,

            "url": "rtmp://127.0.0.1/live/4",

            "name": "youtube",

            "desc": "youtube",

            "key": "111",

            "status": 2,

            "bandwidth": 0

        },

        {

            "switch": 0,

            "index": 2,

            "show_index": 2,

            "protocol": "RTMP",

            "venctype": 0,

            "aenctype": 0,

            "stream_id": 0,

            "url": "rtmp://127.0.0.1/livekj/4",

            "name": "facebook",

            "desc": "facebook",

            "key": "111",

            "status": 2,

            "bandwidth": 0

        }

    ]

}

Parameter

Value

Description

switch

0/1

Push stream switch

0: off

1:on

index

Stream index, users need to operate the stream based on the index

show_index

The stream sequence displayed on the web page, the first five can be

displayed in the shortcut operation of the preview interface

protocol

RTMP/SRT

stream protocol

url

key

desc

name

stream url

stream key

Make notes about the stream information

The name of the stream displayed on the web page

bandwidth

Bit rate when push is successful

status

1/2/3

Push status

1:online

2:offline

3:Failed to connect url

Start/stop streaming

 Start/stop streaming based on the index of the stream.

Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/stream?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "publish",

    "opt": "update_publish_switch",

    "data": {

        "index": 0,

        "switch": 1

    }

}

Parameter

Value

Description

index

Stream index, users need to operate the stream based on the index

switch

0/1

0:off

1:on

Response(example):

{

    "rsp": "succeed",

    "status": "00000"

}

Delete stream information

Delete the stream address already saved in the device based on the index.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/stream?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "publish",

    "opt": "del_publish_info",

    "data": {

        "index": 1

    }

}

Parameter

Value

Description

index

Stream index, users need to operate the stream based on the index

Response(example):

{

    "rsp": "succeed",

    "status": "00000"

}

Modify stream display order

Modify the stream display order on the web page to ensure that the required stream can be displayed in the

shortcut button of the preview interface.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/stream?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "publish",

    "opt": "update_streams_index",

    "data": [

        {

            "index": 1,

            "show_index": 3

        },

        {

            "index": 2,

            "show_index": 2

        },

        {

            "index": 3,

            "show_index": 1

        }

    ]

}

Parameter

Value

Description

index

Stream index, users need to operate the stream based on the index

The index can be obtained by querying the stream list command

show_index

The order in which you want it to appear on the web page

Response(example):

{

    "rsp": "succeed",

    "status": "00000"

}

10. AP

Get AP configuration information

Use this interface to obtain the name, password and opening status of the AP.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/network?option=getinfo&login_check_flag=1

Body(example):

{

  "group": "ap",

  "opt":"get_ap_info"

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed",

    "data": {

        "switch": 1,

        "ssid": "ZowieBox-12343",

        "psk": "12345678"

    }

}

Parameter

Value

Description

switch

0/1

0:off

1:on

ssid

psk

AP service set identifier

AP password

Modify AP configuration information

Modify the AP’s SSID and password.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/network?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ap",

    "opt": "update_ap_info",

    "data": {

        "psk": "1234567891",

        "ssid": "BOX_0012"

    }

}

Parameter

Value

Description

switch

0/1

0:off

1:on

ssid

psk

AP service set identifier

AP password

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

AP switch

Turn AP on or off.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/network?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ap",

    "opt":"ap_switch",

    "data": {

        "switch": 1

    }

}

Parameter

Value

Description

switch

0/1

0:off

1:on

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

11. LAN

Get LAN data

Get all the information about LAN

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/network?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "lan",

    "opt":"get_lan_info"

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed",

    "data": {

        "ip": "192.168.1.76",

        "gateway": "192.168.1.1",

        "dns1": "114.114.114.114",

        "dns2": "",

        "mac": "00:54:89:25:4f:01",

        "subnetmask": "255.255.255.0",

        "name": "eth0",

        "ip_dhcp_switch": 1

    }

}

Parameter

Value

Description

ip

gateway

dns1

dns2

LAN IP address

Default gateway

Preferred DNS

Alternate DNS

Parameter

Value

Description

mac

subnetmask

name

ip_dhcp_switch

0/1

MAC address

subnet mask

lan name

0:DHCP off

1:DHCP enabled

Modify LAN configuration information

When DHCP is closed, the LAN information can be modified manually, and the DNS data can be empty, but it

must be passed. After successfully modifying the LAN information, the device will automatically restart.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/network?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "lan",

    "opt": "set_lan_info",

    "data": {

        "ip_dhcp_switch": 0,

        "ip": "192.168.1.76",

        "gateway": "192.168.1.1",

        "subnetmask": "255.255.255.0",

        "dns_dhcp_switch": 0,

        "dns1": "8.8.8.8",

        "dns2": ""

    }

}

Parameter

Value

Description

ip

gateway

dns1

dns2

mac

subnetmask

name

LAN IP address

Default gateway

Preferred DNS

Alternate DNS

MAC address

subnet mask

lan name

Parameter

Value

Description

ip_dhcp_switch

0/1

0:DHCP off

1:DHCP enabled

Response(example):

After successfully setting the LAN information, the device will automatically restart, so there is no return value.

Check LAN connectivity

Use this interface to check if the device can communicate with other devices on the same LAN.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/network?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "lan",

    "opt":"get_local_ping"

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed",

    "data": {

        "lan_local_status": 1

    }

}

Parameter

Value

Description

lan_local_status

0/1

0:Unable to communicate with LAN

1:Successfully communicated with LAN

Detecting connectivity with the Internet

Check whether the device can connect to the Internet to ensure normal streaming.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/network?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "lan",

    "opt":"get_lan_ping"

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed",

    "data": {

        "lan_net_status": 1

    }

}

Parameter

Value

Description

lan_local_status

0/1

0:Can't connect to the internet

1:Successfully connected to the Internet

Get display IP

To obtain the IP displayed on the LCD screen, first obtain the LAN IP. If the LAN IP cannot be obtained, obtain

the WiFi IP.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://192.168.1.31/network?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "get_main_ip"

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed",

    "data": {

        "ip": "192.168.1.76"

    }

}

12. WIFI

WiFi switch

Turn WiFi on/off.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/network?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "wifi",

    "opt": "wifi_switch",

    "data": {

        "switch": 1

    }

}

Parameter

Value

Description

switch

0/1

0:WiFi off

1:WiFi on

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Get WiFi list

Get all connectable WiFi information, including SSID, signal strength and other information.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/network?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "wifi",

    "opt":"get_wifi_list"

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed",

    "data": [

        {

            "connect_status": 1,

            "ssid": "Zowietek",

            "bssid": "e2:5f:75:36:be:72",

            "frequency": 2437.0,

            "signalLevel": 3,

            "signal_level": -62,

            "flags": "[WPA-PSK-CCMP+TKIP][WPA2-PSK-CCMP+TKIP][WPS][ESS][UTF-8]"

        },

        {

            "connect_status": 0,

            "ssid": "ZowiePTZ-12709",

            "bssid": "ba:13:32:98:df:52",

            "frequency": 2437.0,

            "signalLevel": 4,

            "signal_level": -53,

            "flags": "[WPA2-PSK-CCMP+TKIP][ESS]"

        },

        {

            "connect_status": 0,

            "ssid": "ZowiePTZ-12701",

            "bssid": "ba:13:32:98:d0:16",

            "frequency": 2437.0,

            "signalLevel": 4,

            "signal_level": -59,

            "flags": "[WPA2-PSK-CCMP+TKIP][ESS]"

        },

        {

            "connect_status": 0,

            "ssid": "Zowietek_Wi-Fi5",

            "bssid": "e2:5f:75:36:be:80",

            "frequency": 2437.0,

            "signalLevel": 3,

            "signal_level": -61,

            "flags": "[WPA-PSK-CCMP+TKIP][WPA2-PSK-CCMP+TKIP][ESS][UTF-8]"

        },

        {

            "connect_status": 0,

            "ssid": "DIRECT-d8-HP M130 LaserJet",

            "bssid": "9e:30:5b:a2:29:d8",

            "frequency": 2437.0,

            "signalLevel": 3,

            "signal_level": -65,

            "flags": "[WPA2-PSK-CCMP][WPS][ESS][P2P]"

        },

        {

            "connect_status": 0,

            "ssid": "ZowiePTZ-12265",

            "bssid": "ba:13:32:98:df:dc",

            "frequency": 2437.0,

            "signalLevel": 3,

            "signal_level": -65,

            "flags": "[WPA2-PSK-CCMP+TKIP][ESS]"

        }

    ]

}

Parameter

Value

Description

connect_status

0/1

0:Not connected to this WiFi

1:Already connected to this WiFi

ssid

signalLevel

signal_level

WiFi SSID

WiFi signal strength

WiFi signal strength

Get wifi connection information/status

If the WiFi connection is successful, you can query the connected WiFi information, or you can query whether

the WiFi connection failed or is connecting.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/network?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "wifi",

    "opt":"get_wifi_info"

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed",

    "data": {

        "networkId": 0,

        "ssid": "Zowietek_Wi-Fi5",

        "bssid": "e2:5f:75:36:be:81",

        "freq": 5220,

        "mode": "station",

        "pairwise_cipher": "CCMP",

        "group_cipher": "TKIP",

        "key_mgmt": "WPA2-PSK",

        "wpa_state": "COMPLETED",

        "p2p_device_address": "",

        "address": "b8:13:32:98:a0:54",

        "uuid": "0b370209-9d69-5b92-9c1d-23e51237b977",

        "wifi_connect_status": 4,

        "signalLevel": 4,

        "switch": 1,

        "ip": "192.168.1.137",

        "gateway": "192.168.1.1",

        "dns1": "114.114.114.114",

        "dns2": "",

        "mac": "b8:13:32:98:a0:54",

        "subnetmask": "255.255.255.0"

    }

}

Parameter

Value

Description

ssid

WiFi ssdi

wifi_connect_status

1/2/3/4

1:not connected

2:Connecting

3:Connection failed

4:Connection successful

signal_Level

WiFi signal strength

switch

ip

gateway

dns1

dns2

mac

subnetmask

0/1

0: WiFi off

1: WiFi on

WiFi IP address

Default Gateway

Preferred DNS

Alternate DNS

WiFi MAC address

Subnet mask

Connect to WiFi

Enter the WiFi ssid and password to connect to WiFi.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/network?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "wifi",

    "opt": "wifi_connect",

    "data": {

        "password": "Zowietek",

        "ssid": "Zowietek_Wi-Fi",

        "signalLevel": 3

    }

}

Parameter

Value

Description

WiFi password

WiFi ssid

WiFi signal strength

password

ssid

signalLevel

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

13. Port

Get port information

Get the port information of http,  websocket, rtmp,rtsp, rtp, NDI and visca.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/network?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "ports",

    "opt":"get_ports_info"

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed",

    "data": {

        "http": 80,

        "https": 443,

        "websocket": 8088,

        "rtmp": 1935,

        "onvif": 2000,

        "soap": 1936,

        "rtsp": 8554,

        "rtp": 1234,

        "ndi": 5961,

        "visca_tcp": 5230,

        "visca_udp": 5231

    }

}

Parameter

Value

Description

http

80/1025 to 8079/8081 to 65530

Web port

websocket

rtmp

rtsp

rtp

visca_tcp

visca_udp

1025 to 65530

1025 to 65530

554/1025 to 65530

1025 to 65530

Websocket port

RTMP port

RTSP port

RTP port

1025 to 65530

VISCA TCP port

1025 to 65530

VISCA UDP port

Set port information

Set the port information of http,  websocket, rtmp,rtsp, rtp, NDI and visca.Please restart the device after

modification.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/network?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ports",

    "opt": "set_ports_info",

    "data": {

        "http": 80,

        "rtmp": 1935,

        "rtsp": 8554,

        "visca_tcp": 5232,

        "visca_udp": 5231,

        "rtp":1234,

        "websocket": 8088

    }

}

Parameter

Value

Description

http

80/1025 to 8079/8081 to 65530

Web port

1025 to 65530

1025 to 65530

554/1025 to 65530

1025 to 65530

Websocket port

RTMP port

RTSP port

RTP port

1025 to 65530

VISCA TCP port

1025 to 65530

VISCA UDP port

websocket

rtmp

rtsp

rtp

visca_tcp

visca_udp

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

14. mDNS

Get mDNS information

Get the hostname and domain name of mDNS.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/network?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "mdns",

    "opt":"get_mdns_info"

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed",

    "data": {

        "host_name": "ZowieBox-12021",

        "domain_name": "local"

    }

}

Set mDNS information

Modify mDNS hostname.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

Body(example):

{

    "group": "mdns",

    "opt":"set_mdns_info",

    "data": {

        "host_name": "ZowieBox-12022",

        "domain_name": "local"

    }

}

Response(example):

After the modification is successful, the device will automatically restart with no return

value.

15. User Management

Obtain user information

Get all added user accounts.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/system?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "account",

    "opt": "get_accounts_info",

    "data": {

        "loginUserName": "admin"

    }

}

Parameter

Value

Description

loginUserName

Please enter an existing user name. Administrator rights can query all user

information. Otherwise, you can only query your own user information.

Response(example):

{

    "rsp": "succeed",

    "status": "00000",

    "data": [

        {

            "username": "admin",

            "type": 0,

            "index": 0

        },

        {

            "username": "super",

            "type": 1,

            "index": 1

        },

        {

            "username": "basic",

            "type": 2,

            "index": 2

        }

    ]

}

Parameter

Value

Description

username

Account name

type

index

0:Administrator rights

0/1/2

1:Super permission

2:Basic permissions

Account index

Delete users

Delete accounts based on account index.Please do not delete the administrator account at will.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/system?option=setinfo&login_check_flag=1

Body(example):

{

    "group":"account",

    "opt":"del_account_by_id",

    "data":

    {

        "index":2

    }

}

Parameter

Value

Description

index

Account index

Response(example):

{

    "rsp": "succeed",

    "status": "00000"

}

Add user

Use this interface to add users with three permissions.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/system?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "account",

    "opt": "add_account_info",

    "data": {

        "type": 1,

        "username": "account_1",

        "password": "account_1"

    }

}

Parameter

Value

Description

username

Account name

type

0/1/2

1:Super permission

0:Administrator rights

2:Basic permissions

Account password

password

Response(example):

{

    "rsp": "succeed",

    "status": "00000"

}

Modify user information

Use this interface to modify the user's username, password, and permissions.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/system?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "account",

    "opt": "update_account_by_id",

    "data": {

        "type": 1,

        "username": "admin1",

        "password": "admin",

        "index": 1

    }

}

Parameter

Value

Description

username

Account name

type

0/1/2

1:Super permission

0:Administrator rights

2:Basic permissions

Account password

Account index

password

index

Response(example):

{

    "rsp": "succeed",

    "status": "00000"

}

Log in

Log in to the device using an existing account

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/system?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "account",

    "opt": "login_account",

    "data": {

        "username": "admin",

        "password": "admin"

    }

}

Parameter

Value

Description

username

password

Response(example):

Account name

Account password

{

    "rsp": "succeed",

    "status": "00000",

    "data": {

        "uuid": "749d72a7-a9c6-48fb-b137-b00223250203",

        "type": 0

    }

}

Parameter

Value

Description

uuid

Login identification code, required when logging out

0:Administrator rights

type

0/1/2

1:Super permission

2:Basic permissions

Log out

Log out to log in with another account.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/system?option=setinfo&login_check_flag=1

Body(example):

{

    "group":"account",

    "opt":"logout_account",

    "data":

    {

        "uuid":"22e81ed1-7e50-4182-9115-67443814e490",

        "username":"admin"

    }

}

Parameter

Value

Description

uuid

Login identification code, please enter the uuid returned when logging in

username

Account name

Response(example):

{

    "rsp": "succeed",

    "status": "00000"

}

Verify account existence

Verify whether this account exists, whether the account's password is correct, and whether this account has

administrator rights.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/system?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "account",

    "opt": "verify_account",

    "data": {

        "username": "tyui",

        "password": "super"

    }

}

Parameter

Value

Description

Account name

Account password

username

password

Response(example):

{

    "rsp": "succeed",

    "status": "00000"

}

16. Device time

Get device time

Get the current time of the device, device time setting method and other information.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/system?option=getinfo&login_check_flag=1

Body(example):

{

    "group":"systime",

    "opt":"get_systime_info"

}

Response(example):

{

    "rsp": "succeed",

    "status": "00000",

    "data": {

        "time": {

            "year": 2023,

            "month": 9,

            "day": 27,

            "hour": 16,

            "minute": 56,

            "second": 32

        },

        "setting_mode_id": 0,

        "time_zone_id": "GMT-5",

        "time_type_id": 0,

        "ntp_enable": 0,

        "ntp_server": "ntp.ntsc.ac.cn",

        "ntp_port": 123

    }

}

Parameter

Value

Description

year

month

day

hour

minute

second

Device current year

Device current month

Device current day

Device current hour

Device current minute

Device current second

setting_mode_id

0/1/2

1:Set manually

2:Synchronize with NTP server

0:Synchronize with computer time

time_zone_id

The currently set time zone

ntp_server

ntp_port

NTP server

NTP server port

Set device time

Set the device's current time and how to get it.

 Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://x.x.x.x/system?option=setinfo&login_check_flag=1

Body(example):

{

    "group":"systime",

    "opt":"set_systime_info",

    "data":{

        "ntp_enable": 0,

        "ntp_port": 123,

        "ntp_server": "ntp.ntsc.ac.cn",

        "setting_mode_id": 0,

        "time": {

            "day": 30,

            "hour": 16,

            "minute": 1,

            "month": 6,

            "second": 54,

            "year": 2022

        },

        "time_type_id": 0,

        "time_zone_id": "GMT-8"

    }

}

Parameter

Value

Description

year

month

day

hour

minute

second

setting_mode_id

0/1/2

Device current year

Device current month

Device current day

Device current hour

Device current minute

Device current second

0:Synchronize with computer

time

1:Set manually

2:Synchronize with NTP server

Parameter

Value

Description

GMT11/GMT10/GMT9/GMT8/GMT7/GMT6/

GMT5/GMT4/GMT3/GMT2/GMT1/GMT0/

GMT-1/GMT-2/GMT-3/GMT-4/GMT-5/GMT-6/

GMT-7/GMT-8/GMT-9/GMT-10/GMT-11/GMT-

12/

GMT-13

time_zone_id

ntp_server

ntp_port

The currently set time zone

NTP server

NTP server port

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Get storage device status

17. Recording

 Obtain the storage device's mounting status, file format, storage capacity and other information.

Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://xxx.xxx.xxx.xxx/storage?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "storage_status"

}

Response(example):

{

    "rsp": "succeed",

    "status": "00000",

    "data": [

        {

            "name": "sdcard",

            "index": 0,

            "mount_path": "/mnt/sdcard",

            "status": 0,

            "totalspace": 0,

            "freespace": 0,

            "usagespace": 0,

            "file_system": 0

        },

        {

            "name": "USB1",

            "index": 1,

            "mount_path": "/mnt/USB1",

            "status": 1,

            "totalspace": 29323,

            "freespace": 28553,

            "usagespace": 770,

            "file_system": 1

        },

        {

            "name": "nas1",

            "index": 3,

            "mount_path": "/tmp/nas1",

            "status": 0,

            "totalspace": 0,

            "freespace": 0,

            "usagespace": 0,

            "file_system": 0

        }

    ]

}

Parameter

Value

Description

name

index

mount_path

Storage device type

Storage device index

Mount path

0:Not mounted

1:Mounted

status

0/1/2

2:Storage device is full

totalspace

freespace

usagespace

file_system

0/1/2

3:Storage device read-only

4:Failed to mount storage device

Storage device remaining capacity

Storage device used capacity

0:Unknown format

1:FAT32

2:exFAT

3:NTFS

4:CIFS

5:NFS

Get recording task list

Get a list of all recording tasks

Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://xxx.xxx.xxx.xxx/record?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "record",

    "opt" : "get_task_list"

}

Response(example):

{

    "rsp": "succeed",

    "status": "00000",

    "data": [

        {

            "index": "usb1_0",

            "file_name_prefix": "usb1_0",

            "name": "usb1",

            "record_format": 0,

            "record_mode": 0,

            "record_loop_mode": 0,

            "limit_type": 0,

            "size_limit": 0,

            "time_limit": 0,

            "enable": 0,

            "storage_id": 1,

            "stream_id": 0,

            "audio_stream_id": 0,

            "status": 5,

            "storageInfo": {

                "name": "USB1",

                "index": 1,

                "mount_path": "/mnt/USB1",

                "status": 1,

                "totalspace": 29323,

                "freespace": 28553,

                "usagespace": 770,

                "file_system": 1

            },

            "curr_file_name": "",

            "duration": 0

        },

        {

            "index": "sdcard_0",

            "file_name_prefix": "sdcard_0",

            "name": "sdcard",

            "record_format": 0,

            "record_mode": 0,

            "record_loop_mode": 0,

            "limit_type": 0,

            "size_limit": 0,

            "time_limit": 0,

            "enable": 0,

            "storage_id": 0,

            "stream_id": 0,

            "audio_stream_id": 0,

            "status": 5,

            "restart_record": 1,

            "storageInfo": {

                "name": "sdcard",

                "index": 0,

                "mount_path": "/mnt/sdcard",

                "status": 1,

                "totalspace": 30417,

                "freespace": 8182,

                "usagespace": 22235,

                "file_system": 1

            },

            "curr_file_name": "",

            "duration": 0

        }

    ]

}

Parameter

Value

Description

index

Modify subsequent task information based on the index

file_name_prefix

Video file name

record_format

0/1/2

0:mp4

1:ts

2:mov

record_mode

record_loop_mode

0/1

0/1

0:Disable automatic recording

1:Auto record after starting

0:Close loop recording

1:Start loop recording

limit_type

0/1/2

enable

0/1

0:Size split

1:Time split

0:Record on

1:Record off

Parameter

Value

Description

status

0/1/2/3/4/5

0:Not recorded

1:Recording

2:Recording paused

3:The storage device is full and cannot record.

4:Storage device is invalid/not mounted

5:No signal source

Modify recording task information

Modify the name of the video file, video format, loop recording and other status.

Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://xxx.xxx.xxx.xxx/record?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "record",

    "opt" : "set_task_info",

    "data":{

        "index": "usb1_0",

        "name":"test",

        "record_format": 0,

        "record_mode": 0,

        "file_name_prefix":"stage",

        "record_loop_mode": 0,

        "size_limit":0,

        "time_limit":0,

        "limit_type": 0,

        "storage_id":1,

        "stream_id": 0

    }

}

Parameter

Value

Description

index

name

Get the index through the previous interface

Recording task name

file_name_prefix

Video file name

record_format

0/1/2

0:mp4

1:ts

2:mov

Parameter

Value

Description

record_mode

record_loop_mode

0/1

0/1

0:Disable automatic recording

1:Auto record after starting

0:Close loop recording

1:Start loop recording

limit_type

0/1/2

size_limit

0/1/2/3

time_limit

0/1/2/3

enable

0/1

0:Size split

1:Time split

0:Auto

1:1.5G

2:3G

3:4G

0:Auto

1:15min

2:30min

3:45min

0:Record on

1:Record off

Response(example):

{

    "rsp": "succeed",

    "status": "00000"

}

Start/stop recording

Start or stop recording. Currently, the device only supports recording to one storage device. Recording to

multiple storage devices may cause file corruption, device crash, etc.!

Device Supported: ZowieBox, ZowieCam, ZowiePTZ

http://xxx.xxx.xxx.xxx/record?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "record",

    "opt" : "set_task_enable",

    "data":{

        "index": "usb1_0",

        "enable": 1

    }

}

Parameter

Value

Description

index

usb1_0/sdcard_0/nas1_0

sdcard_0:Using TF card Recording

nas1_0:Using NAS Recording

usb1_0:Using USB Recording

enable

0/1/2/3

0:Record off

1:Record on

2: Pause

3: continue

Response(example):

{

    "rsp": "succeed",

    "status": "00000"

}

Get the video file path

Get the video file path of the specified storage device

http://xxx.xxx.xxx.xxx/record?option=getinfo&login_check_flag=1

Body(example)：

{

    "group": "record",

    "opt" : "get_task_savefiles_page",

    "data": {

        "index": "sdcard_0",

        "control":{

            "currentPage":1,

            "default_Record_Num":10

        },

        "case_num":1

    }

}

Parameter

Value

Description

index

usb1_0/sdcard_0/nas1_0

sdcard_0:Using TF card Recording

usb1_0:Using USB Recording

currentPage

default_Record_Num":

num

num

nas1_0:Using NAS Recording

Get the page number of videos

Number of videos to get per page

Parameter

Value

Description

case_num

/

be obtained. When deleting, all video information

The case number for which information needs to

on the disk is obtained by default.

Response(example):

{

    "rsp": "succeed",

    "status": "00000",

    "data": {

        "storage_info": {

            "name": "TF",

            "index": 0,

            "mount_path": "/mnt/sdcard",

            "status": 1,

            "totalspace": 30430,

            "freespace": 21368,

            "usagespace": 9062,

            "file_system": 2,

            "speed_test_status": 0,

            "write_speed": 0.0,

            "read_speed": 0.0

        },

        "control": {

            "firstPage": 1,

            "currentPage": 1,

            "lastPage": 1,

            "default_Record_Num": 10,

            "sum": 1,

            "frontPage": 0,

            "nextPage": 1

        },

        "storage_files_size": 1,

        "storage_files": [

            {

                "task_id": "sdcard_0",

                "start_time": "2025-06-09 17:52:58",

                "end_time": "2025-06-09 17:53:03",

                "filename": "sdcard_0_20250609175257.mp4",

                "file_url": "/mnt/sdcard/DCIM/MediDVR/case_1/sdcard_0_20250609175257.mp4",

                "file_size": 11,

                "duration": 5,

                "case_num": 1,

                "start_time_obj": {

                    "year": 2025,

                    "month": 6,

                    "day": 9,

                    "hour": 17,

                    "minute": 52,

                    "second": 58

                },

                "end_time_obj": {

                    "year": 2025,

                    "month": 6,

                    "day": 9,

                    "hour": 17,

                    "minute": 53,

                    "second": 3

                }

            }

        ]

    }

}

Parameter

Value

Description

task_id

start_time

end_time

filename

file_url

file_size

case_num

/

/

/

/

/

/

/

Storage Device

Recording start time

End time of recording

Video file name

Video file path

Video file size

Case number

18 .Snapshot

Snapshot

Device Supported: ZowieBox, ZowiePTZ,MediDVR,ZowieCam

http://192.168.1.104/snapshot?option=takephoto&login_check_flag=1

Body(example)：

{

    "num": 3

}

Parameter

Value

Description

num

1 to 3

Number of photos per shot

Response(example):

{

    "rsp": "succeed",

    "status": "00000"

}

Get the photo path

Device Supported: ZowieBox, ZowiePTZ,MediDVR,ZowieCam

http://192.168.1.104/snapshot?option=getinfo&login_check_flag=1

Body(example)：

{

    "group": "photo",

    "opt" : "get_photo_list",

    "data": {

        "storage_id":0,

        "control":{

            "currentPage":1,

            "default_Num":10

        },

        "case_num":1

    }

}

Parameter

Value

Description

storage_id

0/1/2

0:sdcard

1:USB

3:NAS

currentPage

num

Get the page number of photos

default_Num

num

Number of photos to get per page

case_num

/

The case number for which information needs to be obtained. When deleting,

all photo information on the disk is obtained by default.

Response(example):

{

    "rsp": "succeed",

    "status": "00000",

    "total": 2,

    "total_dcm": 0,

    "data": [

        {

            "record_file": "unrecorded",

            "creat_time": {

                "year": 2025,

                "month": 6,

                "day": 9,

                "hour": 16,

                "minute": 7,

                "second": 6

            },

            "filename": "20250609160705.bmp",

            "file_url": "/mnt/sdcard/DCIM/MediDVR/case_1/20250609160705.bmp",

            "file_thumbnail":

"/mnt/sdcard/DCIM/MediDVR/case_1/.thumbnail/20250609160705.bmp",

            "width": 1920,

            "height": 1080

        },

        {

            "record_file": "sdcard_0_20250609175257.mp4",

            "creat_time": {

                "year": 2025,

                "month": 6,

                "day": 9,

                "hour": 17,

                "minute": 53,

                "second": 2

            },

            "filename": "20250609175302.bmp",

            "file_url": "/mnt/sdcard/DCIM/MediDVR/case_1/20250609175302.bmp",

            "file_thumbnail":

"/mnt/sdcard/DCIM/MediDVR/case_1/.thumbnail/20250609175302.bmp",

            "width": 1920,

            "height": 1080

        }

    ]

}

Parameter

Value

Description

total

total_dcm

record_file

creat_time

filename

file_url

file_thumbnail

width

height

/

/

/

/

/

/

/

/

/

Total number of photos

Number of photos in DCIOM format

Whether the photo was taken during video recording. If so, the video file

name is displayed.

Photo creation time

Photo file name

Photo storage path

Photo thumbnail path

Photo Pixels

Photo Pixels

19 . Tally

Get Tally parameters

Get the Tally light status, mode, and current color.

Device Supported: ZowieBox, ZowiePTZ

http://xxx.xxx.xxx.xxx/system?option=getinfo&login_check_flag=1

Body(example):

{

  "group": "tally_led",

  "opt": "get_tally_led_info"

}

Response(example):

{

    "rsp": "succeed",

    "status": "00000",

    "data": {

        "switch": 1,

        "mode_id": 1,

        "mode_list": [

            "AUTO",

            "MANUAL"

        ],

        "color_id": 0,

        "color_list": [

            "OFF",

            "RED",

            "GREEN",

            "BLUE"

        ]

    }

}

Parameter

Value

Description

Switch

mode_id

0/1

0/1

0:off

1:on

0:Auto

1:Manual

Parameter

Value

Description

color_id

0/1/2/3

0:off

1:red

2:green

3:blue

Set Tally parameters

Set the Tally light status, mode, and current color.

Device Supported: ZowieBox, ZowiePTZ

http://xxx.xxx.xxx.xxx/system?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "tally_led",

    "opt": "set_tally_led_info",

    "data": {

        "mode_id": 1,

        "color_id": 0

    }

}

Parameter

Value

Description

mode_id

0/1

color_id

0/1/2/3

0:Auto

1:Manual

0:off

1:red

2:green

3:blue

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Turn on/off Tally

Turn on/off tally light.

Device Supported: ZowieBox, ZowiePTZ

http://xxx.xxx.xxx.xxx/system?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "tally_led",

    "opt": "set_tally_led_switch",

    "data": {

        "switch": 1

    }

}

Parameter

Value

Description

Switch

0/1

0:off

1:on

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Get Tally color

Device Supported: ZowieBox, ZowiePTZ

http://xxx.xxx.xxx.xxx/system?option=getinfo&login_check_flag=1

Body(example):

{

  "group": "tally_led",

  "opt": "get_tally_led_color"

}

Response(example):

{

    "rsp": "succeed",

    "status": "00000",

    "data": {

        "color_id": 3

    }

}

Parameter

Value

Description

color_id

0/1/2/3

0:off

1:red

2:green

3:blue

20 . Restore and reboot

Reboot

Device Supported: ZowieBox, ZowiePTZ, ZowieCam, MediCam

http://xxx.xxx.xxx.xxx/system?option=setinfo&login_check_flag=1

Body (example):

{

    "group":"syscontrol",

    "opt":"set_reboot_info",

    "data":{

        "command": "reboot"

    }

}

Response(example):

{

    "rsp": "succeed",

    "status": "00010"

}

Restore Factory

Device Supported: ZowieBox, ZowiePTZ, ZowieCam, MediCam

http://xxx.xxx.xxx.xxx/system?option=setinfo&login_check_flag=1

Body (example):

{

    "group":"syscontrol",

    "opt":"set_reset_info",

    "data":{

        "command": "reset"

    }

}

Standby

Device Supported: ZowieBox, ZowiePTZ, ZowieCam, MediCam

http://xxx.xxx.xxx.xxx/system?option=setinfo&login_check_flag=1

Body (example):

{

    "group":"syscontrol",

    "opt":"power_off"

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Exit standby

Device Supported: ZowieBox, ZowiePTZ, ZowieCam, MediCam

http://xxx.xxx.xxx.xxx/system?option=setinfo&login_check_flag=1

Body (example):

{

    "group":"syscontrol",

    "opt":"power_on"

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

21. Image Settings

Get exposure setting data

Device Supported: ZowiePTZ, ZowieCAM

http://xxx.xxx.xxx.xxx/camera?option=getinfo&login_check_flag=1

Body(example):

{

  "group": "camera",

  "opt":"get_exposure_info"

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed",

    "data": {

        "mode": {

            "selected_id": 0,

            "mode_list": [

                "Auto",

                "Manual",

                "ShutterFirst",

                "ApertureFirst",

                "BrightFirst"

            ]

        },

        "gain": 0,

        "shutter": {

            "selected_id": 1,

            "shutter_list": [

                "1/25",

                "1/30",

                "1/50",

                "1/60",

                "1/90",

                "1/100",

                "1/120",

                "1/125",

                "1/180",

                "1/250",

                "1/300",

                "1/350",

                "1/500",

                "1/600",

                "1/725",

                "1/1000",

                "1/1500",

                "1/2000",

                "1/3000",

                "1/4000",

                "1/6000",

                "1/10000"

            ]

        },

        "wdr": {

            "selected_id": 0,

            "wdr_list": [

                0,

                1,

                2,

                3,

                4,

                5,

                6,

                7,

                8

            ]

        },

        "flicker": {

            "selected_id": 0,

            "flicker_list": [

                "Disable",

                "50",

                "60",

                "Auto"

            ]

        },

        "bias_enable": 1,

        "bias": 2,

        "backlight_enable": 1,

        "backlight": 8,

        "metering": {

            "selected_id": 0,

            "metering_list": [

                "average",

                "center",

                "spot",

                "matrix"

            ]

        },

        "sensitive": {

            "selected_id": 0,

            "sensitive_list": [

                "Auto",

                "100",

                "200",

                "400",

                "800",

                "1600",

                "3200",

                "6400",

                "12800",

                "25600"

            ]

        },

        "gain_limit": 10

    }

}

Parameter

Value

Description

0: Auto

1: Manual

mode.selected_id

0/1/2/3/4

2: ShutterFirst

3: ApertureFirst

4: BrightFirst

gain

0 to 16

Light Sensitive Gain

0: 1/25

1: 1/30

2: 1/50

3: 1/60

4: 1/90

5: 1/100

6: 1/120

7: 1/125

8: 1/180

9: 1/250

10: 1/300

11: 1/350

12: 1/500

13: 1/600

14: 1/725

15: 1/1000

16: 1/1500

17: 1/2000

18: 1/3000

19: 1/4000

20: 1/6000

21: 1/10000

shutter.selected_id

0 to 21

wdr.selected_id

0 to 8

Parameter

Value

Description

flicker.selected_id

0/1/2/3

0: Disable

1: 50

2: 60

3: Auto

bias

-3 to +3

Exposure Compensation

backlight_enable

0/1

metering.selected_id

0/1/2/3

sensitive.selected_id

0 to 9

0: off

1: on

0: average

1: center

2: spot

3: matrix

0: Auto

1: 100

2: 200

3: 400

4: 800

5:1600

6: 3200

7: 6400

8: 12800

9: 25600

gain_limit

0 to 16

Exposure Gain Limit

Modify exposure setting data

Device Supported: ZowiePTZ, ZowieCAM

http://xxx.xxx.xxx.xxx/camera?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "camera",

    "opt":"set_exposure_info",

     "data": {

        "mode": {

            "selected_id": 2

        },

        "bright": 2,

        "gain": 2,

        "shutter": {

            "selected_id": 3

        },

        "wdr": {

            "selected_id": 0

        },

        "flicker": {

            "selected_id": 0

        },

        "bias_enable": 1,

        "bias": 0,

        "backlight_enable": 1,

        "backlight": 30,

        "metering": {

            "selected_id": 2

        },

        "sensitive": {

            "selected_id": 0

        },

        "save_flag": 1

    }

}

Parameter

Value

Description

mode.selected_id

0/1/2/3

0: Auto

1: Manual

2: ShutterFirst

3: ApertureFirst(ZowiePTZ only)

gain

0 to 16

Light Sensitive Gain

Parameter

Value

Description

0: 1/25

1: 1/30

2: 1/50

3: 1/60

4: 1/90

5: 1/100

6: 1/120

7: 1/125

8: 1/180

9: 1/250

10: 1/300

11: 1/350

12: 1/500

13: 1/600

14: 1/725

15: 1/1000

16: 1/1500

17: 1/2000

18: 1/3000

19: 1/4000

20: 1/6000

21: 1/10000

0: Disable

1: 50

2: 60

3: Auto

shutter.selected_id

0 to 21

wdr.selected_id

0 to 8

flicker.selected_id

0/1/2/3

bias

-3 to 3

Exposure Compensation

backlight_enable

0/1

metering.selected_id

0/1/2/3

0: off

1: on

0: average

1: center

2: spot

3: matrix

Parameter

Value

Description

0: Auto

1: 100

2: 200

3: 400

4: 800

5:1600

6: 3200

7: 6400

8: 12800

9: 25600

0: unsaved

1: save

sensitive.selected_id

0 to 9

save_flag

0/1

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Get aperture value

Device Supported: ZowiePTZ, ZowieCAM

http://xxx.xxx.xxx.xxx/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt":"get_aperture"

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed",

    "data": {

        "selected_id": 12,

        "max_aperture_id": 12,

        "aperture_id": 12,

        "aperture_list": [

            "CLOSE",

            "F11.0",

            "F9.6",

            "F8.0",

            "F6.8",

            "F5.6",

            "F4.8",

            "F4.0",

            "F3.4",

            "F2.8",

            "F2.4",

            "F2.0",

            "F1.6"

        ]

    }

}

Parameter

selected_id

Value

Description

Selected aperture value

max_aperture_id

Maximum aperture value

aperture_id

0 to 12

0: CLOSE

1: F11.0

2: F9.6

3: F8.0

4: F6.8

5: F5.6

6: F4.8

7: F4.0

8: F3.4

9: F2.8

10: F2.4

11: F2.0

12: F1.6

Set aperture value

Device Supported: ZowiePTZ, ZowieCAM

http://xxx.xxx.xxx.xxx/ptz?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "ptz",

    "opt":"set_aperture",

     "data": {

        "aperture": 10

    }

}

Parameter

Value

Description

0: CLOSE

1: F11.0

2: F9.6

3: F8.0

4: F6.8

5: F5.6

6: F4.8

7: F4.0

8: F3.4

9: F2.8

10: F2.4

11: F2.0

12: F1.6

aperture

0 to 12

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Get color setting data

Device Supported: ZowiePTZ, ZowieCAM

http://xxx.xxx.xxx.xxx/camera?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "camera",

    "opt":"get_white_balance_info"

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed",

    "data": {

        "mode": {

            "selected_id": 0,

            "mode_list": [

                "Auto",

                "Manual",

                "VAR",

                "OnePush"

            ]

        },

        "var": {

            "selected_id": 7,

            "var_list": [

                "3000K",

                "3500K",

                "4000K",

                "4500K",

                "5000K",

                "5500K",

                "6000K",

                "6500K"

            ]

        },

        "rgain": 128,

        "bgain": 128,

        "saturation": 30,

        "hue": 0,

        "ircut": {

            "selected_id": 0,

            "mode_list": [

                "IRCUT_DAY",

                "IRCUT_NIGHT"

            ]

        }

    }

}

Parameter

Value

Description

mode.selected_id

0/1/2/3

var.selected_id

0 to 7

0: Auto

1: Manual

2: VAR

3: OnePush

0: 3000K

1: 3500K

2: 4000K

3: 4500K

4: 5000K

5: 5500K

6: 6000K

7: 6500K

rgain

bgain

0 to 255

red gain (electronics)

0 to 255

blue gain (electronics)

saturation

1 to 100

Saturation of colors

Parameter

Value

Description

hue

-180 to 180

Hue of colors

ircut.selected_id

0/1

0: IRCUT_DAY

1: IRCUT_NIGHT

Modify color setting data

Device Supported: ZowiePTZ, ZowieCAM

http://xxx.xxx.xxx.xxx/camera?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "camera",

    "opt":"set_white_balance_info",

    "data": {

        "mode": {

            "selected_id": 0

        },

        "var": {

            "selected_id": 0

        },

        "rgain": 12,

        "bgain": 12,

        "saturation": 80,

        "hue": 10,

        "ircut": {

            "selected_id": 0

        },

        "wb_adjust": 0,

        "save_flag": 1

    }

}

Parameter

Value

Description

mode.selected_id

0/1/2/3

0: Auto

1: Manual

2: VAR

3: OnePush

Parameter

Value

Description

var.selected_id

0 to 7

0: 3000K

1: 3500K

2: 4000K

3: 4500K

4: 5000K

5: 5500K

6: 6000K

7: 6500K

rgain

bgain

0 to 255

red gain (electronics)

0 to 255

blue gain (electronics)

saturation

1 to 100

Saturation of the image

hue

-180 to 180

Hue of the image

0/1

0/1

0: IRCUT_DAY

1: IRCUT_NIGHT

0: unsaved

1: save

ircut.selected_id

save_flag

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Getting image setting data

Device Supported: ZowiePTZ, ZowieCAM

http://xxx.xxx.xxx.xxx/camera?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "camera",

    "opt":"get_image_info"

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed",

    "data": {

        "brightness": 4,

        "contrast": 7,

        "sharpness": 2,

        "gamma": {

            "selected_id": 2,

            "gamma_list": [

                "0.38(1/2.6)",

                "0.42(1/2.4)",

                "0.45(1/2.2)",

                "0.50(1/2.0)",

                "0.55(1/1.8)",

                "0.63(1/1.6)",

                "0.71(1/1.4)",

                "0.83(1/1.2)",

                "1.00(1/1.0)"

            ]

        },

        "flip": {

            "selected_id": 0,

            "flip_list": [

                "Disable",

                "H-Filp",

                "V-Filp",

                "HV-Flip",

                "Auto Flip"

            ]

        },

        "color_gray": {

            "selected_id": 0,

            "cg_list": [

                "colour",

                "gray"

            ]

        }

    }

}

Parameter

Value

Description

brightness

contrast

sharpness

0 to 8

Brightness of the image

0 to 15

Contrast of the image

0 to 10

Sharpness of the image

Parameter

Value

Description

gamma.selected_id

0 to 8

flip.selected_id

0 to 4

color_gray.selected_id

0/1

0: 0.38(1/2.6)

1: 0.42(1/2.4)

2: 0.45(1/2.2)

3: 0.50(1/2.0)

4: 0.55(1/1.8)

5: 0.63(1/1.6)

6: 0.71(1/1.4)

7: 0.83(1/1.2)

8: 1.00(1/1.0)

0: Disable

1: H-Filp

2: V-Filp

3: HV-Flip

4: Auto Flip

0: colour

1: gray

Modify image setting data

Device Supported: ZowiePTZ, ZowieCAM

http://xxx.xxx.xxx.xxx/camera?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "camera",

    "opt":"set_image_info",

    "data": {

        "brightness": 0,

        "contrast": 0,

        "sharpness": 0,

        "gamma": {

            "selected_id": 0

        },

        "flip": {

            "selected_id": 0

        },

        "color_gray": {

            "selected_id": 0

        },

        "save_flag": 1

    }

}

Parameter

Value

Description

brightness

contrast

sharpness

0 to 8

Brightness of the image

0 to 15

Contrast of the image

0 to 10

Sharpness of the image

gamma.selected_id

0 to 8

flip.selected_id

0 to 4

color_gray.selected_id

save_flag

0/1

0/1

0: 0.38(1/2.6)

1: 0.42(1/2.4)

2: 0.45(1/2.2)

3: 0.50(1/2.0)

4: 0.55(1/1.8)

5: 0.63(1/1.6)

6: 0.71(1/1.4)

7: 0.83(1/1.2)

8: 1.00(1/1.0)

0: Disable

1: H-Filp

2: V-Filp

3: HV-Flip

4: Auto Flip

0: colour

1: gray

0: unsaved

1: save

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Get noise reduction setting data

Device Supported: ZowiePTZ, ZowieCAM

http://xxx.xxx.xxx.xxx/camera?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "camera",

    "opt":"get_nr_info"

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed",

    "data": {

        "nr_2d": {

            "selected_id": 3,

            "nr_2d_list": [

                "Disable",

                "1",

                "2",

                "3",

                "4",

                "5",

                "6",

                "7",

                "8"

            ]

        },

        "nr_3d": {

            "selected_id": 3,

            "nr_3d_list": [

                "Disable",

                "1",

                "2",

                "3",

                "4",

                "5",

                "6",

                "7",

                "8"

            ]

        },

        "correction": {

            "selected_id": 0,

            "correction_list": [

                "Disable",

                "1",

                "2",

                "3",

                "4",

                "5"

            ]

        }

    }

}

Parameter

Value

Description

nr_2d.selected_id

0 to 8

nr_3d.selected_id

0 to 8

correction.selected_id

0 to 5

0: Disable

1: 1

2: 2

3: 3

4: 4

5: 5

6: 6

7: 7

8: 8

0: Disable

1: 1

2: 2

3: 3

4: 4

5: 5

6: 6

7: 7

8: 8

0: Disable

1: 1

2: 2

3: 3

4: 4

5: 5

Modify noise reduction setting data

Device Supported: ZowiePTZ, ZowieCAM

http://xxx.xxx.xxx.xxx/camera?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "camera",

    "opt":"set_nr_info",

    "data": {

        "nr_2d": {

            "selected_id": 0

        },

        "nr_3d": {

            "selected_id": 0

        },

        "correction": {

            "selected_id": 0

        },

        "save_flag": 1

    }

}

Parameter

Value

Description

nr_2d.selected_id

0 to 8

nr_3d.selected_id

0 to 8

correction.selected_id

0 to 5

save_flag

0/1

0: Disable

1: 1

2: 2

3: 3

4: 4

5: 5

6: 6

7: 7

8: 8

0: Disable

1: 1

2: 2

3: 3

4: 4

5: 5

6: 6

7: 7

8: 8

0: Disable

1: 1

2: 2

3: 3

4: 4

5: 5

0: unsaved

1: save

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Get image style data

Device Supported: ZowiePTZ, ZowieCAM

http://xxx.xxx.xxx.xxx/camera?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "camera",

    "opt":"get_style_info"

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed",

    "data": {

        "selected_id": 0,

        "style_list": [

            "default",

            "normal",

            "clarity",

            "bright",

            "soft",

            "beautify"

        ],

        "style_param_list": [

            {

                "id": 0,

                "desc": "default",

                "brightness_id": 4,

                "sharpness_id": 2,

                "contrast_id": 7,

                "nr_2d_id": 2,

                "nr_3d_id": 3,

                "gamma_id": 2,

                "saturation": 30,

                "hue": 0,

                "cem_id": 0,

                "metering_id": 0

            },

            {

                "id": 1,

                "desc": "normal",

                "brightness_id": 5,

                "sharpness_id": 2,

                "contrast_id": 7,

                "nr_2d_id": 2,

                "nr_3d_id": 3,

                "gamma_id": 2,

                "saturation": 30,

                "hue": 0,

                "cem_id": 0,

                "metering_id": 0

            },

            {

                "id": 2,

                "desc": "clarity",

                "brightness_id": 5,

                "sharpness_id": 3,

                "contrast_id": 10,

                "nr_2d_id": 2,

                "nr_3d_id": 3,

                "gamma_id": 1,

                "saturation": 30,

                "hue": 0,

                "cem_id": 0,

                "metering_id": 0

            },

            {

                "id": 3,

                "desc": "bright",

                "brightness_id": 5,

                "sharpness_id": 2,

                "contrast_id": 9,

                "nr_2d_id": 2,

                "nr_3d_id": 3,

                "gamma_id": 1,

                "saturation": 40,

                "hue": 0,

                "cem_id": 0,

                "metering_id": 0

            },

            {

                "id": 4,

                "desc": "soft",

                "brightness_id": 4,

                "sharpness_id": 0,

                "contrast_id": 6,

                "nr_2d_id": 2,

                "nr_3d_id": 3,

                "gamma_id": 2,

                "saturation": 30,

                "hue": 0,

                "cem_id": 0,

                "metering_id": 0

            },

            {

                "id": 5,

                "desc": "beautify",

                "brightness_id": 6,

                "sharpness_id": 2,

                "contrast_id": 4,

                "nr_2d_id": 2,

                "nr_3d_id": 3,

                "gamma_id": 1,

                "saturation": 30,

                "hue": 0,

                "cem_id": 0,

                "metering_id": 0

            }

        ],

        "medi_style_list": [

            "default",

            "color enhancement",

            "image sharpness",

            "normal",

            "clarity",

            "bright"

        ],

        "medi_style_param_list": [

            {

                "id": 0,

                "desc": "default",

                "brightness_id": 4,

                "sharpness_id": 2,

                "contrast_id": 8,

                "nr_2d_id": 2,

                "nr_3d_id": 3,

                "gamma_id": 2,

                "saturation": 30,

                "hue": 0,

                "cem_id": 0,

                "metering_id": 2

            },

            {

                "id": 1,

                "desc": "color enhancement",

                "brightness_id": 4,

                "sharpness_id": 2,

                "contrast_id": 9,

                "nr_2d_id": 2,

                "nr_3d_id": 3,

                "gamma_id": 2,

                "saturation": 30,

                "hue": 0,

                "cem_id": 1,

                "metering_id": 2

            },

            {

                "id": 2,

                "desc": "image sharpness",

                "brightness_id": 4,

                "sharpness_id": 4,

                "contrast_id": 10,

                "nr_2d_id": 2,

                "nr_3d_id": 3,

                "gamma_id": 1,

                "saturation": 30,

                "hue": 0,

                "cem_id": 1,

                "metering_id": 2

            },

            {

                "id": 3,

                "desc": "normal",

                "brightness_id": 5,

                "sharpness_id": 2,

                "contrast_id": 7,

                "nr_2d_id": 2,

                "nr_3d_id": 3,

                "gamma_id": 2,

                "saturation": 30,

                "hue": 0,

                "cem_id": 0,

                "metering_id": 0

            },

            {

                "id": 4,

                "desc": "clarity",

                "brightness_id": 5,

                "sharpness_id": 3,

                "contrast_id": 10,

                "nr_2d_id": 2,

                "nr_3d_id": 3,

                "gamma_id": 1,

                "saturation": 30,

                "hue": 0,

                "cem_id": 0,

                "metering_id": 0

            },

            {

                "id": 5,

                "desc": "bright",

                "brightness_id": 5,

                "sharpness_id": 2,

                "contrast_id": 9,

                "nr_2d_id": 2,

                "nr_3d_id": 3,

                "gamma_id": 1,

                "saturation": 40,

                "hue": 0,

                "cem_id": 0,

                "metering_id": 0

            }

        ]

    }

}

Parameter

Value

Description

selected_id

0 to 5

0: default

1: normal

2: clarity

3: bright

4: soft

5: beautify

desc

Style of the image

brightness_id

0 to 8

Brightness of the image

sharpness_id

contrast_id

nr_2d_id

nr_3d_id

gamma_id

saturation

0 to 10

0 to 15

0 to 8

0 to 8

0 to 8

Sharpness of the image

Contrast of the image

2D noise reduction

3D noise reduction

Gamma curve of the image

1 to 100

Saturation of the image

hue

-180 to 180

Hue of the image

metering_id

0/1/2/3

Metering modes for exposure

Modify image style data

Device Supported: ZowiePTZ, ZowieCAM

http://xxx.xxx.xxx.xxx/camera?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "camera",

    "opt":"set_style_info",

    "data": {

        "selected_id": 1,

        "save_flag": 1

    }

}

Parameter

Value

Description

selected_id

0 to 5

save_flag

0/1

0: default

1: normal

2: clarity

3: bright

4: soft

5: beautify

0: unsaved

1: save

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

Get AE Lock status

Device Supported: ZowiePTZ, ZowieCAM

http://xxx.xxx.xxx.xxx/camera?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "camera",

    "opt":"get_ae_lock_status"

}

Response(example):

{

    "status": "00000",

    "rsp": "succeed",

    "data": {

        "ae_lock_status": 0

    }

}

Parameter

Value

Description

ae_lock_status

0/1

0: off

1: on

Set AE Lock status

Device Supported: ZowiePTZ, ZowieCAM

http://xxx.xxx.xxx.xxx/camera?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "camera",

    "opt":"set_ae_lock_status",

    "data":{

        "ae_lock_status":0

    }

}

Parameter

Value

Description

ae_lock_status

0/1

0: off

1: on

Response(example):

{

    "status": "00000",

    "rsp": "succeed"

}

22.Patient Case

Create Patient Information

Device Supported: MediDVR

http://xxx.xxx.xxx.xxx/patient?option=setinfo&login_check_flag=1

Body(example):

{

    "group":"patient",

    "opt":"add_message_task",

    "data":{

        "firstname": "王",
        "thirdname": "位",

        "secondname": "位",

        "year": "2024",

        "month": "1",

        "day": "1",

        "id": "1",

        "doctor": "20000000",

        "message":"0",

        "gender": 0,

        "case_num":1,

        "Examination_finding":"iiiiiiiii",

        "Check_prompt":"pppppppppppppp",

        "add_mode":0,

        "patient_id":1

    }

}

Parameter

Value

Description

firstname

thirdname

secondname

year

month

day

id

doctor

message

/

/

/

/

/

/

/

/

/

patient's first name

patient's third name

patient's second name

Year of Birth

Month of birth

Day of birth

Patient's id

Doctor name

Description of the patient's condition

gender

0/1

Patient gender

0:male

1:female

Response(example)：

{

    "rsp": "succeed",

    "status": "00000"

}

Case Query

Query all case information

Device Supported: MediDVR

http://xxx.xxx.xxx.xxx/patient?option=getinfo&login_check_flag=1

Body(example):

{

    "group":"patient",

    "opt":"get_message_task",

    "data":{

        "sort":0

    }

}

Response(example)：

{

    "rsp": "succeed",

    "status": "00000",

    "data": [

        {

            "id": "00000002",

            "firstname": "Patient2",

            "secondname": "",

            "thirdname": "",

            "gender": -1,

            "patient_id": 2,

            "patient_case": 1,

            "case_num": 2,

            "check_time": {

                "year": 2025,

                "month": 6,

                "day": 10,

                "hour": 13,

                "minute": 25,

                "second": 1

            },

            "check_info": null,

            "year": "",

            "month": "",

            "day": "",

            "doctor": "",

            "message": "",

            "path": "/mnt/sdcard/DCIM/MediDVR/case_2",

            "patient_case_amount": 1

        }

    ]

}

Parameter

Value

Description

id

firstname

thirdname

/

/

/

patient id

patient's first name

patient's third name

Parameter

Value

Description

secondname

case_num

patient_id

patient_case

check_time.year

check_time.month

check_time.day

check_time.hour

check_time.minute

check_time.second

year

month

day

doctor

message

/

/

/

/

/

/

/

/

/

/

/

/

/

/

patient's second name

case number

patient id

patient case id

Year of Check time

Month of check time

Day of check time

hour of check time

minute of check time

second of check time

year of birth

month of birth

day of birth

Doctor name

Description of the patient's condition

gender

-1/0/1

path

patient_case_amount

/

/

Patient gender

-1:Not filled

0:male

1:female

case path

Total number of cases

23.Pan/Tilt/Zoom/Focus Control

Pan/Tilt Control

Device Supported: ZowieBox, ZowieBox-SDI, ZowieKBD

http://xxx.xxx.xxx.xxx/ptzctrl?option=transmit&login_check_flag=1

Body(example):

{

    "group":"ptz_ctrl",

    "opt":"pan_tilt",

    "data":

    {

        "pan_speed":10,

        "tilt_speed":10

    }

}

Parameter

Value

Description

Adjust the speed and direction of pan

0: Speed is 0, no movement is performed.

-10 to -1: Move rightward. The smaller the value, the faster the speed.

1 to 10: Move leftward. The larger the value, the faster the speed.

Adjust the speed and direction of tilt

0: Speed is 0, no movement is performed.

-10 to -1: Move downwards. The smaller the value, the faster the speed.

1 to 10: Move upwards. The larger the value, the faster the speed.

pan_speed

-10 to 10

tilt_speed

-10 to 10

Response(example)：

{

    "rsp": "succeed",

    "status": "00000"

}

Zoom Control

Device Supported: ZowieBox, ZowieBox-SDI, ZowieKBD

http://xxx.xxx.xxx.xxx/ptzctrl?option=transmit&login_check_flag=1

Body(example):

{

    "group":"ptz_ctrl",

    "opt":"zoom",

    "data":

    {

        "zoom_speed":10

    }

}

Parameter

Value

Description

zoom_speed

-10 to 10

Adjust the speed and direction of zoom

0: Speed is 0, no zoom is performed.

-10 to -1: Execute zoom-; the smaller the value, the faster the speed.

1 to 10: Execute zoom+, the higher the value, the faster the speed

Response(example)：

{

    "rsp": "succeed",

    "status": "00000"

}

Go Home

Return to default position

Device Supported: ZowieBox, ZowieBox-SDI, ZowieKBD

http://xxx.xxx.xxx.xxx/ptzctrl?option=transmit&login_check_flag=1

Body(example):

{

    "group": "ptz_ctrl",

    "opt": "gohome",

    "data":{

        "pan_speed":1,

        "tilt_speed":1,

        "zoom_speed":1

    }

}

Parameter

Value

Description

pan_speed

tilt_speed

zoom_speed

/

/

/

Note: This speed parameter is currently disabled.

Note: This speed parameter is currently disabled.

Note: This speed parameter is currently disabled.

Response(example)：

{

    "rsp": "succeed",

    "status": "00000"

}

Preset position settings

Device Supported: ZowieBox, ZowieBox-SDI, ZowieKBD

http://xxx.xxx.xxx.xxx/ptzctrl?option=transmit&login_check_flag=1

Body(example):

{

    "group":"ptz_ctrl",

    "opt":"set_preset",

    "data":

    {

        "preset_id":1

    }

}

Parameter

Value

Description

Preset ID that needs to be set.

Note: When the protocol is NDI, “preset_id” has a range restriction [0-99].

preset_id

/

Response(example)：

{

    "rsp": "succeed",

    "status": "00000"

}

Preset position recall

Device Supported: ZowieBox, ZowieBox-SDI, ZowieKBD

http://xxx.xxx.xxx.xxx/ptzctrl?option=transmit&login_check_flag=1

Body(example):

{

    "group":"ptz_ctrl",

    "opt":"recall_preset",

    "data":

    {

        "preset_id":257,

        "pan_speed":1,

        "tilt_speed":1,

        "zoom_speed":1

    }

}

Parameter

Value

Description

Preset ID that needs to be called.

Note: When the protocol is NDI, “preset_id” has a range restriction [0-99].

Note: This speed parameter is currently disabled.

Note: This speed parameter is currently disabled.

Note: This speed parameter is currently disabled.

preset_id

pan_speed

tilt_speed

tilt_speed

/

/

/

/

Response(example)：

{

    "rsp": "succeed",

    "status": "00000"

}

Preset position deletion

Device Supported: ZowieBox, ZowieBox-SDI, ZowieKBD

http://xxx.xxx.xxx.xxx/ptzctrl?option=transmit&login_check_flag=1

Body(example):

{

    "group":"ptz_ctrl",

    "opt":"clear_preset",

    "data":

    {

        "preset_id":5

    }

}

Parameter

Value

Description

preset_id

/

Preset ID that needs to be deleted.

Note: NDI protocol does not support this feature

Response(example)：

{

    "rsp": "succeed",

    "status": "00000"

}

Focus mode settings

Device Supported: ZowieBox, ZowieBox-SDI, ZowieKBD

http://xxx.xxx.xxx.xxx/ptzctrl?option=transmit&login_check_flag=1

Body(example):

{

    "group":"ptz_ctrl",

    "opt":"set_focus_mode",

    "data":

    {

        "mode_id":0

    }

}

Parameter

Value

Description

Focus mode

0: Auto focus

1: Manual focus

mode_id

0/1/2

2: OnePush focus

Note: This feature is only supported by the following protocols: Visca, ONVIF,

NDI, Pelco D. Additionally, OnePush focus is exclusively compatible with the

Visca protocol.

Response(example)：

{

    "rsp": "succeed",

    "status": "00000"

}

Focus mode acquisition

Device Supported: ZowieBox, ZowieBox-SDI, ZowieKBD

http://xxx.xxx.xxx.xxx/ptzctrl?option=transmit&login_check_flag=1

Body(example):

{

    "group":"ptz_ctrl",

    "opt":"get_focus_mode"

}

Response(example)：

{

    "rsp": "succeed",

    "status": "00000",

    "data": {

        "mode_id": 1

    }

}

Parameter

Value

Description

mode_id

0/1/2

Focus mode

0: Auto focus

1: Manual focus

2: OnePush focus

Focus control (continuous)

Device Supported: ZowieBox, ZowieBox-SDI, ZowieKBD

http://xxx.xxx.xxx.xxx/ptzctrl?option=transmit&login_check_flag=1

Body(example):

{

    "group":"ptz_ctrl",

    "opt":"focus",

    "data":

    {

        "focus_speed":10

    }

}

Parameter

Value

Description

Adjust the speed and direction of zoom

0: Speed is 0, no focusing is performed.

focus_speed

-10 to 10

-10 to -1: Execute Focus Far, the smaller the value, the faster the speed.

1 to 10: Execute Focus Near, the higher the value, the faster the speed.

Note: Speed settings are not yet effective.

Response(example)：

{

    "rsp": "succeed",

    "status": "00000"

}

24. Temperature

Get CPU temperature

Device Supported: ZowieBox, ZowieBox-SDI, ZowieKBD, ZowiePTZ, ZowieCam,

http://xxx.xxx.xxx/system?option=getinfo&login_check_flag=1

Body(example):

{

    "group": "get_cpu_temp"

}

Response(example)：

{

    "rsp": "succeed",

    "status": "00000",

    "data": {

        "temp": 79.5

    }

}

Parameter

Value

Description

temp

/

Actual CPU temperature of the device

25. Tally

Get Tally mode

Device Supported: ZowieBox, ZowieBox-SDI, ZowiePTZ, ZowieCam,ZowieREC

http://xxx.xxx.xxx.xxx/system?option=getinfo&login_check_flag=1

Body(example):

{

  "group": "tally_led",

  "opt": "get_tally_led_info"

}

Response(example)：

{

    "rsp": "succeed",

    "status": "00000",

    "data": {

        "switch": 1,

        "mode_id": 1,

        "mode_list": [

            "AUTO",

            "MANUAL",

            "Tally",

            "Game",

            "Recoder"

        ],

        "color_id": 1,

        "color_list": [

            "OFF",

            "RED",

            "GREEN",

            "BLUE"

        ]

    }

}

Parameter

Value

Description

switch

0/1

0:off

1:on

0:Auto

1:Manual

mode_id

0-4

2:Tally

3:Game(Only for Zowiebox andZowieREC)

4:Recoder(Only for ZowieREC)

color_list

0-3

0:off

1:Red

2:Green

3:Blue

Turn On/Off Tally

Device Supported: ZowieBox, ZowieBox-SDI, ZowiePTZ, ZowieCam,ZowieREC

http://xxx.xxx.xxx.xxx/system?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "tally_led",

    "opt": "set_tally_led_switch",

    "data": {

        "switch": 1

    }

}

Parameter

Value

Description

switch

0/1

0: on

1: Off

Response(example)：

{

    "status": "00000",

    "rsp": "succeed"

}

Set Tally parameters

Device Supported: ZowieBox, ZowieBox-SDI, ZowiePTZ, ZowieCam,ZowieREC

http://xxx.xxx.xxx.xxx/system?option=setinfo&login_check_flag=1

Body(example):

{

    "group": "tally_led",

    "opt": "set_tally_led_info",

    "data": {

        "mode_id": 1,

        "color_id": 0

    }

}

Parameter

Value

Description

mode_id

0-4

2: Tally

0: Auto

1: Manual

3: Game(Only for ZowieBox and ZowieREC)

4: Recoder(Only for ZowieREC)

color_list

0-3

0: off

1: Red

2: Green

3: Blue

Response(example)：

{

    "status": "00000",

    "rsp": "succeed"

}

Get the current color of Tally

Device Supported: ZowieBox, ZowieBox-SDI, ZowiePTZ, ZowieCam,ZowieREC

http://xxx.xxx.xxx.xxx/system?option=getinfo&login_check_flag=1

Body(example):

{

  "group": "tally_led",

  "opt": "get_tally_led_color"

}

Response(example)：

{

    "rsp": "succeed",

    "status": "00000",

    "data": {

        "color_id": 0

    }

}

Parameter

Value

Description

color_list

0-3

0: off

1: Red

2: Green

3: Blue

RESTful API Version History Template

*Version 1.5

1. Added Chapter 25,Tally interface

Version 1.4

1. Added interface for obtaining CPU temperature

Version 1.3

1. Added Chapter 23, Pan/Tilt/Zoom/Focus related control interfaces

Version 1.2

1. Add interfaces: patient addition and query, photo and video file query

Version 1.1

1. Added Chapter 20, Exposure related Interfaces


