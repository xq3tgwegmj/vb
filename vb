-- Gui to Lua
-- Version: 3.2

-- Variables
getgenv().antiArrest = false

-- Instances
local ScreenGui = Instance.new("ScreenGui")
local TopBar = Instance.new("Frame")
local BG = Instance.new("Frame")
local UICorner = Instance.new("UICorner")
local KillFrame = Instance.new("Frame")
local KillScrollingFrame = Instance.new("ScrollingFrame")
local UIListLayout = Instance.new("UIListLayout")
local PlrBTN = Instance.new("TextButton")
local MustHaveGun = Instance.new("TextLabel")
local TazeFrame = Instance.new("Frame")
local TazeScrollingFrame = Instance.new("ScrollingFrame")
local UIListLayout_2 = Instance.new("UIListLayout")
local PlrBTN_2 = Instance.new("TextButton")
local JailFrame = Instance.new("Frame")
local JailScrollingFrame = Instance.new("ScrollingFrame")
local UIListLayout_3 = Instance.new("UIListLayout")
local PlrBTN_3 = Instance.new("TextButton")
local FollowFrame = Instance.new("Frame")
local Follower = Instance.new("TextLabel")
local FollowerBox = Instance.new("TextBox")
local Following = Instance.new("TextLabel")
local FollowingrBox = Instance.new("TextBox")
local StopFollowing = Instance.new("TextButton")
local StartFollowing = Instance.new("TextButton")
local UICorner_2 = Instance.new("UICorner")
local MainFrame = Instance.new("Frame")
local AntiArrest = Instance.new("TextLabel")
local AntiArrestBTN = Instance.new("TextButton")
local UICorner_3 = Instance.new("UICorner")
local Alarm = Instance.new("TextLabel")
local AlarmBTN = Instance.new("TextButton")
local UICorner_4 = Instance.new("UICorner")
local UICorner_5 = Instance.new("UICorner")
local TextLabel = Instance.new("TextLabel")
local Nav = Instance.new("Frame")
local Main = Instance.new("TextButton")
local UICorner_6 = Instance.new("UICorner")
local UIListLayout_4 = Instance.new("UIListLayout")
local Kill = Instance.new("TextButton")
local UICorner_7 = Instance.new("UICorner")
local Taze = Instance.new("TextButton")
local UICorner_8 = Instance.new("UICorner")
local Jail = Instance.new("TextButton")
local UICorner_9 = Instance.new("UICorner")
local Follow = Instance.new("TextButton")
local UICorner_10 = Instance.new("UICorner")
local UICorner_11 = Instance.new("UICorner")
local ArrestFrame = Instance.new("Frame")
local ArrestScrollingFrame = Instance.new("ScrollingFrame")
local PlrBTN_4 = Instance.new("TextButton")
local Arrest = Instance.new("TextButton")
local UICorner_12 = Instance.new("UICorner")
local UIListLayout_5 = Instance.new("UIListLayout")
local UnArrestScrollingFrame = Instance.new("ScrollingFrame")
local UIListLayout_6 = Instance.new("UIListLayout")
local PlrBTN_5 = Instance.new("TextButton")
local ArrestInfo = Instance.new("TextLabel")
local UnArrestInfo = Instance.new("TextLabel")

--Properties:

ScreenGui.Parent = game.CoreGui
ScreenGui.ZIndexBehavior = Enum.ZIndexBehavior.Sibling
ScreenGui.ResetOnSpawn = false

TopBar.Name = "TopBar"
TopBar.Parent = ScreenGui
TopBar.BackgroundColor3 = Color3.fromRGB(35, 35, 35)
TopBar.Position = UDim2.new(0.3859649, 0, 0.340983599, 0)
TopBar.Size = UDim2.new(0.22807017, 0, 0.316393435, 0)

BG.Name = "BG"
BG.Parent = TopBar
BG.BackgroundColor3 = Color3.fromRGB(24, 24, 24)
BG.Position = UDim2.new(0, 0, 0.149273813, 0)
BG.Size = UDim2.new(1.00100005, 0, 0.850726128, 0)

UICorner.CornerRadius = UDim.new(0, 10)
UICorner.Parent = BG

KillFrame.Name = "KillFrame"
KillFrame.Parent = BG
KillFrame.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
KillFrame.BackgroundTransparency = 1.000
KillFrame.BorderSizePixel = 0
KillFrame.Position = UDim2.new(-1.01963508e-07, 0, 0.189963624, 0)
KillFrame.Size = UDim2.new(1.00000012, 0, 0.754063845, 0)
KillFrame.Visible = false

KillScrollingFrame.Name = "KillScrollingFrame"
KillScrollingFrame.Parent = KillFrame
KillScrollingFrame.Active = true
KillScrollingFrame.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
KillScrollingFrame.BackgroundTransparency = 1.000
KillScrollingFrame.BorderColor3 = Color3.fromRGB(34, 34, 34)
KillScrollingFrame.BorderSizePixel = 0
KillScrollingFrame.Position = UDim2.new(0.0233879797, 0, 0.168461144, 0)
KillScrollingFrame.Size = UDim2.new(0.950220287, 0, 0.816920936, 0)
KillScrollingFrame.CanvasSize = UDim2.new(0, 0, 0, 0)
KillScrollingFrame.ScrollBarThickness = 5
KillScrollingFrame.AutomaticCanvasSize = Enum.AutomaticSize.Y
KillScrollingFrame.ScrollBarImageColor3 = Color3.fromRGB(100, 100, 100)

UIListLayout.Parent = KillScrollingFrame
UIListLayout.HorizontalAlignment = Enum.HorizontalAlignment.Center
UIListLayout.SortOrder = Enum.SortOrder.LayoutOrder

PlrBTN.Name = "PlrBTN"
PlrBTN.Parent = KillScrollingFrame
PlrBTN.BackgroundColor3 = Color3.fromRGB(30, 30, 30)
PlrBTN.BorderColor3 = Color3.fromRGB(53, 53, 53)
PlrBTN.Position = UDim2.new(1.02065478e-07, 0, 0.048780486, 0)
PlrBTN.Size = UDim2.new(0.934447825, 0, 0.170731708, 0)
PlrBTN.Visible = false
PlrBTN.Font = Enum.Font.Nunito
PlrBTN.Text = "Username"
PlrBTN.TextColor3 = Color3.fromRGB(200, 200, 200)
PlrBTN.TextSize = 14.000
PlrBTN.RichText = true

MustHaveGun.Name = "MustHaveGun"
MustHaveGun.Parent = KillFrame
MustHaveGun.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
MustHaveGun.BackgroundTransparency = 1.000
MustHaveGun.BorderSizePixel = 0
MustHaveGun.Position = UDim2.new(0.0233879797, 0, 0, 0)
MustHaveGun.Size = UDim2.new(0.948883772, 0, 0.168461367, 0)
MustHaveGun.Font = Enum.Font.Nunito
MustHaveGun.Text = "<b>[REQUIRES GUN]</b>"
MustHaveGun.TextColor3 = Color3.fromRGB(255, 255, 255)
MustHaveGun.TextSize = 14.000
MustHaveGun.RichText = true

TazeFrame.Name = "TazeFrame"
TazeFrame.Parent = BG
TazeFrame.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
TazeFrame.BackgroundTransparency = 1.000
TazeFrame.BorderSizePixel = 0
TazeFrame.Position = UDim2.new(-1.01963508e-07, 0, 0.189963624, 0)
TazeFrame.Size = UDim2.new(1.00000012, 0, 0.754063845, 0)
TazeFrame.Visible = false

TazeScrollingFrame.Name = "TazeScrollingFrame"
TazeScrollingFrame.Parent = TazeFrame
TazeScrollingFrame.Active = true
TazeScrollingFrame.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
TazeScrollingFrame.BackgroundTransparency = 1.000
TazeScrollingFrame.BorderColor3 = Color3.fromRGB(34, 34, 34)
TazeScrollingFrame.BorderSizePixel = 0
TazeScrollingFrame.Position = UDim2.new(0.0233879797, 0, 0, 0)
TazeScrollingFrame.Size = UDim2.new(0.950220287, 0, 0.98538208, 0)
TazeScrollingFrame.CanvasSize = UDim2.new(0, 0, 0, 0)
TazeScrollingFrame.ScrollBarThickness = 5
TazeScrollingFrame.AutomaticCanvasSize = Enum.AutomaticSize.Y
TazeScrollingFrame.ScrollBarImageColor3 = Color3.fromRGB(100, 100, 100)

UIListLayout_2.Parent = TazeScrollingFrame
UIListLayout_2.HorizontalAlignment = Enum.HorizontalAlignment.Center
UIListLayout_2.SortOrder = Enum.SortOrder.LayoutOrder

PlrBTN_2.Name = "PlrBTN"
PlrBTN_2.Parent = TazeScrollingFrame
PlrBTN_2.BackgroundColor3 = Color3.fromRGB(30, 30, 30)
PlrBTN_2.BorderColor3 = Color3.fromRGB(53, 53, 53)
PlrBTN_2.Position = UDim2.new(1.02065478e-07, 0, 0.048780486, 0)
PlrBTN_2.Size = UDim2.new(0.934447825, 0, 0.170731708, 0)
PlrBTN_2.Visible = false
PlrBTN_2.Font = Enum.Font.Nunito
PlrBTN_2.Text = "Username"
PlrBTN_2.TextColor3 = Color3.fromRGB(200, 200, 200)
PlrBTN_2.TextSize = 14.000
PlrBTN_2.RichText = true

JailFrame.Name = "JailFrame"
JailFrame.Parent = BG
JailFrame.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
JailFrame.BackgroundTransparency = 1.000
JailFrame.BorderSizePixel = 0
JailFrame.Position = UDim2.new(-1.01963508e-07, 0, 0.189963624, 0)
JailFrame.Size = UDim2.new(1.00000012, 0, 0.754063845, 0)
JailFrame.Visible = false

JailScrollingFrame.Name = "JailScrollingFrame"
JailScrollingFrame.Parent = JailFrame
JailScrollingFrame.Active = true
JailScrollingFrame.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
JailScrollingFrame.BackgroundTransparency = 1.000
JailScrollingFrame.BorderColor3 = Color3.fromRGB(34, 34, 34)
JailScrollingFrame.BorderSizePixel = 0
JailScrollingFrame.Position = UDim2.new(0.0233879797, 0, 0, 0)
JailScrollingFrame.Size = UDim2.new(0.950220287, 0, 0.98538208, 0)
JailScrollingFrame.CanvasSize = UDim2.new(0, 0, 0, 0)
JailScrollingFrame.ScrollBarThickness = 5
JailScrollingFrame.AutomaticCanvasSize = Enum.AutomaticSize.Y
JailScrollingFrame.ScrollBarImageColor3 = Color3.fromRGB(100, 100, 100)

UIListLayout_3.Parent = JailScrollingFrame
UIListLayout_3.HorizontalAlignment = Enum.HorizontalAlignment.Center
UIListLayout_3.SortOrder = Enum.SortOrder.LayoutOrder

PlrBTN_3.Name = "PlrBTN"
PlrBTN_3.Parent = JailScrollingFrame
PlrBTN_3.BackgroundColor3 = Color3.fromRGB(30, 30, 30)
PlrBTN_3.BorderColor3 = Color3.fromRGB(53, 53, 53)
PlrBTN_3.Position = UDim2.new(1.02065478e-07, 0, 0.048780486, 0)
PlrBTN_3.Size = UDim2.new(0.934447825, 0, 0.170731708, 0)
PlrBTN_3.Visible = false
PlrBTN_3.Font = Enum.Font.Nunito
PlrBTN_3.Text = "Username"
PlrBTN_3.TextColor3 = Color3.fromRGB(200, 200, 200)
PlrBTN_3.TextSize = 14.000
PlrBTN_3.RichText = true

FollowFrame.Name = "FollowFrame"
FollowFrame.Parent = BG
FollowFrame.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
FollowFrame.BackgroundTransparency = 1.000
FollowFrame.BorderSizePixel = 0
FollowFrame.Position = UDim2.new(-1.01963508e-07, 0, 0.189963624, 0)
FollowFrame.Size = UDim2.new(1.00000012, 0, 0.754063845, 0)
FollowFrame.Visible = false

Follower.Name = "Follower"
Follower.Parent = FollowFrame
Follower.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
Follower.BackgroundTransparency = 1.000
Follower.BorderSizePixel = 0
Follower.Position = UDim2.new(0.0233879797, 0, 0, 0)
Follower.Size = UDim2.new(0.948883772, 0, 0.281537741, 0)
Follower.Font = Enum.Font.Nunito
Follower.Text = "<b>Follower:</b>"
Follower.TextColor3 = Color3.fromRGB(255, 255, 255)
Follower.TextSize = 14.000
Follower.TextXAlignment = Enum.TextXAlignment.Left
Follower.RichText = true

FollowerBox.Name = "FollowerBox"
FollowerBox.Parent = Follower
FollowerBox.BackgroundColor3 = Color3.fromRGB(35, 35, 35)
FollowerBox.BorderColor3 = Color3.fromRGB(53, 53, 53)
FollowerBox.Position = UDim2.new(0.213380203, 0, 0.291666657, 0)
FollowerBox.Size = UDim2.new(0.786619782, 0, 0.458333343, 0)
FollowerBox.ClearTextOnFocus = false
FollowerBox.Font = Enum.Font.Nunito
FollowerBox.PlaceholderColor3 = Color3.fromRGB(98, 98, 98)
FollowerBox.PlaceholderText = "Username ..."
FollowerBox.Text = ""
FollowerBox.TextColor3 = Color3.fromRGB(255, 255, 255)
FollowerBox.TextSize = 14.000
FollowerBox.TextXAlignment = Enum.TextXAlignment.Left
FollowerBox.RichText = true

Following.Name = "Following"
Following.Parent = FollowFrame
Following.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
Following.BackgroundTransparency = 1.000
Following.BorderSizePixel = 0
Following.Position = UDim2.new(0.0233879797, 0, 0.211153269, 0)
Following.Size = UDim2.new(0.948883772, 0, 0.281537741, 0)
Following.Font = Enum.Font.Nunito
Following.Text = "<b>Following:</b>"
Following.TextColor3 = Color3.fromRGB(255, 255, 255)
Following.TextSize = 14.000
Following.TextXAlignment = Enum.TextXAlignment.Left
Following.RichText = true

FollowingrBox.Name = "FollowingrBox"
FollowingrBox.Parent = Following
FollowingrBox.BackgroundColor3 = Color3.fromRGB(35, 35, 35)
FollowingrBox.BorderColor3 = Color3.fromRGB(53, 53, 53)
FollowingrBox.Position = UDim2.new(0.213380203, 0, 0.291666657, 0)
FollowingrBox.Size = UDim2.new(0.786619782, 0, 0.458333343, 0)
FollowingrBox.ClearTextOnFocus = false
FollowingrBox.Font = Enum.Font.Nunito
FollowingrBox.PlaceholderColor3 = Color3.fromRGB(98, 98, 98)
FollowingrBox.PlaceholderText = "Username ..."
FollowingrBox.Text = ""
FollowingrBox.TextColor3 = Color3.fromRGB(255, 255, 255)
FollowingrBox.TextSize = 14.000
FollowingrBox.TextXAlignment = Enum.TextXAlignment.Left
FollowingrBox.RichText = true

StopFollowing.Name = "StopFollowing"
StopFollowing.Parent = FollowFrame
StopFollowing.BackgroundColor3 = Color3.fromRGB(53, 53, 53)
StopFollowing.Position = UDim2.new(0.0233879797, 0, 0.49269104, 0)
StopFollowing.Size = UDim2.new(0.948883653, 0, 0.17972292, 0)
StopFollowing.Font = Enum.Font.Nunito
StopFollowing.Text = "Stop all follows"
StopFollowing.TextColor3 = Color3.fromRGB(255, 255, 255)
StopFollowing.TextSize = 14.000
StopFollowing.TextWrapped = true
StopFollowing.Visible = false

UICorner_2.CornerRadius = UDim.new(0, 4)
UICorner_2.Parent = StopFollowing

StartFollowing.Name = "StartFollowing"
StartFollowing.Parent = FollowFrame
StartFollowing.BackgroundColor3 = Color3.fromRGB(53, 53, 53)
StartFollowing.Position = UDim2.new(0.0233879797, 0, 0.49269104, 0)
StartFollowing.Size = UDim2.new(0.948883653, 0, 0.17972292, 0)
StartFollowing.Font = Enum.Font.Nunito
StartFollowing.Text = "Start follow"
StartFollowing.TextColor3 = Color3.fromRGB(255, 255, 255)
StartFollowing.TextSize = 14.000
StartFollowing.TextWrapped = true

UICorner_11.CornerRadius = UDim.new(0, 4)
UICorner_11.Parent = StartFollowing

MainFrame.Name = "MainFrame"
MainFrame.Parent = BG
MainFrame.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
MainFrame.BackgroundTransparency = 1.000
MainFrame.BorderSizePixel = 0
MainFrame.Position = UDim2.new(-1.01963508e-07, 0, 0.189963624, 0)
MainFrame.Size = UDim2.new(1.00000012, 0, 0.754063845, 0)

AntiArrest.Name = "AntiArrest"
AntiArrest.Parent = MainFrame
AntiArrest.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
AntiArrest.BackgroundTransparency = 1.000
AntiArrest.BorderSizePixel = 0
AntiArrest.Position = UDim2.new(0.0233879797, 0, 0, 0)
AntiArrest.Size = UDim2.new(0.948883772, 0, 0.281537741, 0)
AntiArrest.Font = Enum.Font.Nunito
AntiArrest.Text = "<b>Anti-Arrest</b>"
AntiArrest.TextColor3 = Color3.fromRGB(255, 255, 255)
AntiArrest.TextSize = 14.000
AntiArrest.TextXAlignment = Enum.TextXAlignment.Left
AntiArrest.RichText = true

AntiArrestBTN.Name = "AntiArrestBTN"
AntiArrestBTN.Parent = AntiArrest
AntiArrestBTN.BackgroundColor3 = Color3.fromRGB(53, 53, 53)
AntiArrestBTN.Position = UDim2.new(0.235915497, 0, 0.198973224, 0)
AntiArrestBTN.Size = UDim2.new(0.764084518, 0, 0.594594181, 0)
AntiArrestBTN.Font = Enum.Font.Nunito
AntiArrestBTN.Text = "Enable"
AntiArrestBTN.TextColor3 = Color3.fromRGB(255, 255, 255)
AntiArrestBTN.TextSize = 14.000
AntiArrestBTN.TextWrapped = true

UICorner_3.CornerRadius = UDim.new(0, 4)
UICorner_3.Parent = AntiArrestBTN

Alarm.Name = "Alarm"
Alarm.Parent = MainFrame
Alarm.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
Alarm.BackgroundTransparency = 1.000
Alarm.BorderSizePixel = 0
Alarm.Position = UDim2.new(0.0233879797, 0, 0.218076363, 0)
Alarm.Size = UDim2.new(0.948883772, 0, 0.281537741, 0)
Alarm.Font = Enum.Font.Nunito
Alarm.Text = "<b>Alarm</b>"
Alarm.TextColor3 = Color3.fromRGB(255, 255, 255)
Alarm.TextSize = 14.000
Alarm.TextXAlignment = Enum.TextXAlignment.Left
Alarm.RichText = true

AlarmBTN.Name = "AlarmBTN"
AlarmBTN.Parent = Alarm
AlarmBTN.BackgroundColor3 = Color3.fromRGB(53, 53, 53)
AlarmBTN.Position = UDim2.new(0.235915497, 0, 0.198973224, 0)
AlarmBTN.Size = UDim2.new(0.764084518, 0, 0.594594181, 0)
AlarmBTN.Font = Enum.Font.Nunito
AlarmBTN.Text = "Enable"
AlarmBTN.TextColor3 = Color3.fromRGB(255, 255, 255)
AlarmBTN.TextSize = 14.000
AlarmBTN.TextWrapped = true

UICorner_4.CornerRadius = UDim.new(0, 4)
UICorner_4.Parent = AlarmBTN

UICorner_5.CornerRadius = UDim.new(0, 10)
UICorner_5.Parent = TopBar

TextLabel.Parent = TopBar
TextLabel.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
TextLabel.BackgroundTransparency = 1.000
TextLabel.Position = UDim2.new(0.0234113708, 0, 0, 0)
TextLabel.Size = UDim2.new(0.973244071, 0, 0.149273813, 0)
TextLabel.Font = Enum.Font.Nunito
TextLabel.Text = "<b><font color='rgb(255,255,255)'>Vyron Border</font></b>".."<font size='15' color='rgb(100,100,100)'>by hani786</font>"
TextLabel.TextColor3 = Color3.fromRGB(255, 255, 255)
TextLabel.TextSize = 24.000
TextLabel.TextWrapped = true
TextLabel.TextXAlignment = Enum.TextXAlignment.Left
TextLabel.RichText = true

Nav.Name = "Nav"
Nav.Parent = TopBar
Nav.BackgroundColor3 = Color3.fromRGB(29, 29, 29)
Nav.BorderSizePixel = 0
Nav.Position = UDim2.new(0, 0, 0.14507772, 0)
Nav.Size = UDim2.new(1, 0, 0.165803105, 0)

Main.Name = "Main"
Main.Parent = Nav
Main.BackgroundColor3 = Color3.fromRGB(53, 53, 53)
Main.Position = UDim2.new(0, 0, 0.198973373, 0)
Main.Size = UDim2.new(0.133779258, 0, 0.594594181, 0)
Main.Font = Enum.Font.Nunito
Main.Text = "Main"
Main.TextColor3 = Color3.fromRGB(255, 255, 255)
Main.TextSize = 14.000
Main.TextWrapped = true

UICorner_6.CornerRadius = UDim.new(0, 4)
UICorner_6.Parent = Main

UIListLayout_4.Parent = Nav
UIListLayout_4.FillDirection = Enum.FillDirection.Horizontal
UIListLayout_4.HorizontalAlignment = Enum.HorizontalAlignment.Center
UIListLayout_4.SortOrder = Enum.SortOrder.LayoutOrder
UIListLayout_4.VerticalAlignment = Enum.VerticalAlignment.Center
UIListLayout_4.Padding = UDim.new(0.03, 0)

Kill.Name = "Kill"
Kill.Parent = Nav
Kill.BackgroundColor3 = Color3.fromRGB(29, 29, 29)
Kill.Position = UDim2.new(0, 0, 0.198973373, 0)
Kill.Size = UDim2.new(0.133779258, 0, 0.594594181, 0)
Kill.Font = Enum.Font.Nunito
Kill.Text = "Kill"
Kill.TextColor3 = Color3.fromRGB(255, 255, 255)
Kill.TextSize = 14.000
Kill.TextWrapped = true

UICorner_7.CornerRadius = UDim.new(0, 4)
UICorner_7.Parent = Kill

Taze.Name = "Taze"
Taze.Parent = Nav
Taze.BackgroundColor3 = Color3.fromRGB(29, 29, 29)
Taze.Position = UDim2.new(0, 0, 0.198973373, 0)
Taze.Size = UDim2.new(0.133779258, 0, 0.594594181, 0)
Taze.Font = Enum.Font.Nunito
Taze.Text = "Taze"
Taze.TextColor3 = Color3.fromRGB(255, 255, 255)
Taze.TextSize = 14.000
Taze.TextWrapped = true

UICorner_8.CornerRadius = UDim.new(0, 4)
UICorner_8.Parent = Taze

Jail.Name = "Jail"
Jail.Parent = Nav
Jail.BackgroundColor3 = Color3.fromRGB(29, 29, 29)
Jail.Position = UDim2.new(0, 0, 0.198973373, 0)
Jail.Size = UDim2.new(0.133779258, 0, 0.594594181, 0)
Jail.Font = Enum.Font.Nunito
Jail.Text = "Jail"
Jail.TextColor3 = Color3.fromRGB(255, 255, 255)
Jail.TextSize = 14.000
Jail.TextWrapped = true

UICorner_9.CornerRadius = UDim.new(0, 4)
UICorner_9.Parent = Jail

Follow.Name = "Follow"
Follow.Parent = Nav
Follow.BackgroundColor3 = Color3.fromRGB(29, 29, 29)
Follow.Position = UDim2.new(0, 0, 0.198973373, 0)
Follow.Size = UDim2.new(0.133779258, 0, 0.594594181, 0)
Follow.Font = Enum.Font.Nunito
Follow.Text = "Follow"
Follow.TextColor3 = Color3.fromRGB(255, 255, 255)
Follow.TextSize = 14.000
Follow.TextWrapped = true

UICorner_10.CornerRadius = UDim.new(0, 4)
UICorner_10.Parent = Follow

ArrestFrame.Name = "ArrestFrame"
ArrestFrame.Parent = BG
ArrestFrame.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
ArrestFrame.BackgroundTransparency = 1.000
ArrestFrame.BorderSizePixel = 0
ArrestFrame.Position = UDim2.new(-1.01963508e-07, 0, 0.189963624, 0)
ArrestFrame.Size = UDim2.new(1.00000012, 0, 0.754063845, 0)
ArrestFrame.Visible = false

ArrestScrollingFrame.Name = "ArrestScrollingFrame"
ArrestScrollingFrame.Parent = ArrestFrame
ArrestScrollingFrame.Active = true
ArrestScrollingFrame.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
ArrestScrollingFrame.BackgroundTransparency = 1.000
ArrestScrollingFrame.BorderColor3 = Color3.fromRGB(34, 34, 34)
ArrestScrollingFrame.BorderSizePixel = 0
ArrestScrollingFrame.Position = UDim2.new(0.511194408, 0, 0.16153805, 0)
ArrestScrollingFrame.Size = UDim2.new(0.46112749, 0, 0.823844016, 0)
ArrestScrollingFrame.CanvasSize = UDim2.new(0, 0, 0, 0)
ArrestScrollingFrame.ScrollBarThickness = 5
ArrestScrollingFrame.AutomaticCanvasSize = Enum.AutomaticSize.Y
ArrestScrollingFrame.ScrollBarImageColor3 = Color3.fromRGB(100, 100, 100)

PlrBTN_4.Name = "PlrBTN"
PlrBTN_4.Parent = ArrestScrollingFrame
PlrBTN_4.BackgroundColor3 = Color3.fromRGB(30, 30, 30)
PlrBTN_4.BorderColor3 = Color3.fromRGB(53, 53, 53)
PlrBTN_4.Position = UDim2.new(1.02065478e-07, 0, 0.048780486, 0)
PlrBTN_4.Size = UDim2.new(0.934447825, 0, 0.170731708, 0)
PlrBTN_4.Visible = false
PlrBTN_4.Font = Enum.Font.Nunito
PlrBTN_4.Text = "Username"
PlrBTN_4.TextColor3 = Color3.fromRGB(200, 200, 200)
PlrBTN_4.TextSize = 14.000
PlrBTN_4.RichText = true

UnArrestScrollingFrame.Name = "UnarrestScrollingFrame"
UnArrestScrollingFrame.Parent = ArrestFrame
UnArrestScrollingFrame.Active = true
UnArrestScrollingFrame.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
UnArrestScrollingFrame.BackgroundTransparency = 1.000
UnArrestScrollingFrame.BorderColor3 = Color3.fromRGB(34, 34, 34)
UnArrestScrollingFrame.BorderSizePixel = 0
UnArrestScrollingFrame.Position = UDim2.new(0.0233879797, 0, 0.16153805, 0)
UnArrestScrollingFrame.Size = UDim2.new(0.46112749, 0, 0.823844016, 0)
UnArrestScrollingFrame.CanvasSize = UDim2.new(0, 0, 0, 0)
UnArrestScrollingFrame.ScrollBarThickness = 5
UnArrestScrollingFrame.AutomaticCanvasSize = Enum.AutomaticSize.Y
UnArrestScrollingFrame.ScrollBarImageColor3 = Color3.fromRGB(100, 100, 100)

UIListLayout_6.Parent = UnArrestScrollingFrame
UIListLayout_6.HorizontalAlignment = Enum.HorizontalAlignment.Center
UIListLayout_6.SortOrder = Enum.SortOrder.LayoutOrder

PlrBTN_5.Name = "PlrBTN"
PlrBTN_5.Parent = UnArrestScrollingFrame
PlrBTN_5.BackgroundColor3 = Color3.fromRGB(30, 30, 30)
PlrBTN_5.BorderColor3 = Color3.fromRGB(53, 53, 53)
PlrBTN_5.Position = UDim2.new(1.02065478e-07, 0, 0.048780486, 0)
PlrBTN_5.Size = UDim2.new(0.934447825, 0, 0.170731708, 0)
PlrBTN_5.Visible = false
PlrBTN_5.Font = Enum.Font.Nunito
PlrBTN_5.Text = "Username"
PlrBTN_5.TextColor3 = Color3.fromRGB(200, 200, 200)
PlrBTN_5.TextSize = 14.000
PlrBTN_5.RichText = true

ArrestInfo.Name = "ArrestInfo"
ArrestInfo.Parent = ArrestFrame
ArrestInfo.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
ArrestInfo.BackgroundTransparency = 1.000
ArrestInfo.Position = UDim2.new(0.0385018252, 0, 0, 0)
ArrestInfo.Size = UDim2.new(0.43089959, 0, 0.149273813, 0)
ArrestInfo.Font = Enum.Font.Nunito
ArrestInfo.Text = "<b>Arrest</b>"
ArrestInfo.TextColor3 = Color3.fromRGB(255, 255, 255)
ArrestInfo.TextSize = 15.000
ArrestInfo.TextWrapped = true
ArrestInfo.RichText = true

UnArrestInfo.Name = "UnArrestInfo"
UnArrestInfo.Parent = ArrestFrame
UnArrestInfo.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
UnArrestInfo.BackgroundTransparency = 1.000
UnArrestInfo.Position = UDim2.new(0.526308239, 0, 0.00807690248, 0)
UnArrestInfo.Size = UDim2.new(0.43089959, 0, 0.149273813, 0)
UnArrestInfo.Font = Enum.Font.Nunito
UnArrestInfo.Text = "<b>Unarrest</b>"
UnArrestInfo.TextColor3 = Color3.fromRGB(255, 255, 255)
UnArrestInfo.TextSize = 15.000
UnArrestInfo.TextWrapped = true
UnArrestInfo.RichText = true

Arrest.Name = "Arrest"
Arrest.Parent = Nav
Arrest.BackgroundColor3 = Color3.fromRGB(29, 29, 29)
Arrest.Position = UDim2.new(0, 0, 0.198973373, 0)
Arrest.Size = UDim2.new(0.133779258, 0, 0.594594181, 0)
Arrest.Font = Enum.Font.Nunito
Arrest.Text = "Arrest"
Arrest.TextColor3 = Color3.fromRGB(255, 255, 255)
Arrest.TextSize = 14.000
Arrest.TextWrapped = true

UICorner_12.CornerRadius = UDim.new(0, 4)
UICorner_12.Parent = Arrest

UIListLayout_5.Parent = ArrestScrollingFrame
UIListLayout_5.HorizontalAlignment = Enum.HorizontalAlignment.Center
UIListLayout_5.SortOrder = Enum.SortOrder.LayoutOrder




-- Functions
--kill
function kill(name)
	if name ~= game.Players.LocalPlayer.Name then
		if game.Players:FindFirstChild(name) then
			local plr = game.Players[name]
			local gun
			--find gun
			for _, v in pairs(game.Players.LocalPlayer.Character:GetChildren()) do
				if v:FindFirstChild("Barrel") then
					gun = v
					break
				end
			end
			for _, v in pairs(game.Players.LocalPlayer.Backpack:GetChildren()) do
				if v:FindFirstChild("Barrel") then
					gun = v
					break
				end
			end
			--remote event
			if gun then
				local args = {
					[1] = gun,
					[2] = game:GetService("Players").LocalPlayer,
					[3] = plr.Character.Humanoid,
					[4] = plr.Character.HumanoidRootPart,
					[5] = {
						[1] = 10,
						[2] = 2,
						[3] = true,
						[4] = 14.471323013305664,
						[5] = false,
						[6] = 10000,
						[7] = 1000
					},
					[6] = {
						[1] = 0,
						[2] = 0,
						[3] = false,
						[4] = false,
						[5] = gun.GunScript_Server.IgniteScript,
						[6] = gun.GunScript_Server.IcifyScript,
						[7] = 100,
						[8] = 100
					},
					[7] = {
						[1] = true,
						[2] = 5,
						[3] = 3
					},
					[8] = plr.Character.Head,
					[9] = {
						[1] = false,
						[2] = {
							[1] = 1930359546
						},
						[3] = 1,
						[4] = 1.5,
						[5] = 1,
						[6] = gun.GunScript_Local.GoreEffect
					}
				}
				for i = 1,10 do
					if gun then
						game:GetService("ReplicatedStorage").Remotes.InflictTarget:InvokeServer(unpack(args))
					end
				end
			else
				if KillScrollingFrame:FindFirstChild(name) then
					local plrbtn = KillScrollingFrame[name]
					plrbtn.BorderColor3 = Color3.fromRGB(255,0,0)
					plrbtn.Text = name.."<b><font color='rgb(255,0,0)'> - Requires gun!</font></b>"
					wait(.5)
					plrbtn.BorderColor3 = Color3.fromRGB(53, 53, 53)
					plrbtn.Text = name
				end
			end
		end
	end
end

--taze
function taze(name)
	if game.Players:FindFirstChild(name) then
		local plr = game.Players[name]
		local args = {
			[1] = game:GetService("ReplicatedStorage").Equipment.Taser,
			[2] = game:GetService("Players").LocalPlayer,
			[3] = plr.Character.Humanoid,
			[4] = plr.Character.HumanoidRootPart,
			[5] = {
				[1] = 0,
				[2] = 2,
				[3] = false,
				[4] = 11.87596321105957,
				[5] = false,
				[6] = 10000,
				[7] = 1000
			},
			[6] = {
				[1] = 0,
				[2] = 0,
				[3] = false,
				[4] = true,
				[5] = game:GetService("ReplicatedStorage").Equipment.Taser.GunScript_Server.IgniteScript,
				[6] = game:GetService("ReplicatedStorage").Equipment.Taser.GunScript_Server.IcifyScript,
				[7] = 100,
				[8] = 100
			},
			[7] = {
				[1] = true,
				[2] = 5,
				[3] = 3
			},
			[8] = plr.Character.Head,
			[9] = {
				[1] = false,
				[2] = {
					[1] = 1930359546
				},
				[3] = 1,
				[4] = 1.5,
				[5] = 1,
				[6] = game:GetService("ReplicatedStorage").Equipment.Taser.GunScript_Local.GoreEffect
			}
		}
		game:GetService("ReplicatedStorage").Remotes.InflictTarget:InvokeServer(unpack(args))
	end
end

--jail
function jail(name)
	if game.Players:FindFirstChild(name) then
		game:GetService("ReplicatedStorage").CuffEvents.ToJail:FireServer(name)
	end
end

--arrest
function arrest(name)
	if game.Players:FindFirstChild(name) then
		local plr = game.Players[name]
		local args = {
			[1] = plr,
			[2] = "Tie"
		}
		game:GetService("ReplicatedStorage").CuffEvents.TieEvent:FireServer(unpack(args))
	end
end
--unarrest
function unarrest(name)
	if game.Players:FindFirstChild(name) then
		local plr = game.Players[name]
		local args = {
			[1] = plr,
			[2] = "Untie"
		}
		game:GetService("ReplicatedStorage").CuffEvents.TieEvent:FireServer(unpack(args))
	end
end


--players add
function addPlayer(name)
	if game.Players:FindFirstChild(name) then
		local plr = game.Players[name]
		for _, v in pairs(BG:GetDescendants()) do
			if v.Name == "PlrBTN" then
				local clone = v:Clone()
				clone.Name = name
				clone.Text = name
				clone.Parent = v.Parent
				clone.Visible = true
				clone.MouseButton1Click:Connect(function()
					if string.find(v.Parent.Name,"Kill") then
						kill(name)
					elseif string.find(v.Parent.Name,"Taze") then
						taze(name)
					elseif string.find(v.Parent.Name,"Jail") then
						jail(name)
					elseif v.Parent.Name == "ArrestScrollingFrame" then
						unarrest(name)
					elseif v.Parent.Name == "UnarrestScrollingFrame" then
						arrest(name)
					end
				end)
			end
		end
	end
end
--players remove
function removePlayer(name)
	for _, v in pairs(BG:GetDescendants()) do
		if v.Name == name then
			v:Destroy()
		end
	end
end





-- Players
--existing
for _, v in pairs(game.Players:GetPlayers()) do
	local name = v.Name
	addPlayer(name)
end
--future
game.Players.PlayerAdded:Connect(function(plr)
	local name = plr.Name
	addPlayer(name)
end)
--leaving
game.Players.PlayerRemoving:Connect(function(plr)
	local name = plr.Name
	removePlayer(name)
end)




-- Navbar
for _, v in pairs(Nav:GetChildren()) do
	if v:IsA("TextButton") then
		v.MouseButton1Click:Connect(function()
			--set button colors to disabled
			for _, x in pairs(Nav:GetChildren()) do
				if x:IsA("TextButton") then
					x.BackgroundColor3 = Color3.fromRGB(29,29,29)
				end
			end
			--set color to enabled
			v.BackgroundColor3 = Color3.fromRGB(53,53,53)
			--enable according frame
			for _, x in pairs(BG:GetChildren()) do
				if x:IsA("Frame") then
					if string.find(x.Name,v.Name) then
						x.Visible = true
					else
						x.Visible = false
					end
				end
			end
		end)
	end
end





-- Main Frame
--anti-arrest
AntiArrestBTN.MouseButton1Click:Connect(function()
	getgenv().antiArrest = not getgenv().antiArrest
	if getgenv().antiArrest then
		AntiArrestBTN.Text = "Disable"
	else
		AntiArrestBTN.Text = "Enable"
	end
	while getgenv().antiArrest do
		wait(0.5)
		local unfollow = {
			[1] = game:GetService("Players").LocalPlayer,
			[2] = "Stop"
		}
		local unarrest = {
			[1] = game:GetService("Players").LocalPlayer,
			[2] = "Untie"
		}
		game:GetService("ReplicatedStorage").CuffEvents.TieEvent:FireServer(unpack(unfollow))
		game:GetService("ReplicatedStorage").CuffEvents.TieEvent:FireServer(unpack(unarrest))
	end
end)

--alarm
AlarmBTN.MouseButton1Click:Connect(function()
	for _, v in pairs(game.Workspace:GetDescendants()) do
		if v:IsA("ClickDetector") and v.Parent.Name == "Part" then
			if v.Parent.Color == Color3.fromRGB(255,0,0) then
				fireclickdetector(v)
			end
		end
	end
end)




-- Follow Frame
--start follow
StartFollowing.MouseButton1Click:Connect(function()
	if FollowerBox.Text ~= "" and FollowingrBox.Text ~= "" then
		if game.Players:FindFirstChild(FollowerBox.Text) and game.Players:FindFirstChild(FollowingrBox.Text) then
			local follower = game.Players[FollowerBox.Text]
			local following = game.Players[FollowingrBox.Text]
			local args = {
				[1] = follower,
				[2] = "Follow",
				[3] = following
			}
			game:GetService("ReplicatedStorage").CuffEvents.TieEvent:FireServer(unpack(args))
			--disable buttons
			for _, v in pairs(FollowFrame:GetChildren()) do
				if v.Name ~= "StopFollowing" then
					v.Visible = false
				else
					v.Visible = true
				end
			end
		elseif not game.Players:FindFirstChild(FollowerBox.Text) or not game.Players:FindFirstChild(FollowingrBox.Text) then
			StartFollowing.Visible = false
			local originalTextFollowing = FollowingrBox.Text
			local originalTextFollower = FollowerBox.Text
			if not game.Players:FindFirstChild(FollowerBox.Text) then
				FollowerBox.Text = FollowerBox.Text.." <b><font color='rgb(255,0,0)'>- Player not found!</font></b>"
				FollowerBox.TextEditable = false
				FollowerBox.BorderColor3 = Color3.fromRGB(255,0,0)
			end
			if not game.Players:FindFirstChild(FollowingrBox.Text) then
				FollowingrBox.Text = FollowingrBox.Text.." <b><font color='rgb(255,0,0)'>- Player not found!</font></b>"
				FollowingrBox.TextEditable = false
				FollowingrBox.BorderColor3 = Color3.fromRGB(255,0,0)
			end
			wait(1)
			FollowingrBox.Text = originalTextFollowing
			FollowingrBox.TextEditable = true
			FollowingrBox.BorderColor3 = Color3.fromRGB(53, 53, 53)
			FollowerBox.Text = originalTextFollower
			FollowerBox.TextEditable = true
			FollowerBox.BorderColor3 = Color3.fromRGB(53, 53, 53)
			
			StartFollowing.Visible = true
		end
	else
		if FollowerBox.Text == "" then
			FollowerBox.BorderColor3 = Color3.fromRGB(255,0,0)
		end
		if FollowingrBox.Text == "" then
			FollowingrBox.BorderColor3 = Color3.fromRGB(255,0,0)
		end
		wait(.5)
		FollowerBox.BorderColor3 = Color3.fromRGB(53, 53, 53)
		FollowingrBox.BorderColor3 = Color3.fromRGB(53, 53, 53)
	end
end)
--stop follow
StopFollowing.MouseButton1Click:Connect(function()
	if game.Players:FindFirstChild(FollowingrBox.Text) then
		local args = {
			[1] = game.Players:FindFirstChild(FollowingrBox.Text),
			[2] = "Stop"
		}
		game:GetService("ReplicatedStorage").CuffEvents.TieEvent:FireServer(unpack(args))
		for _, v in pairs(FollowFrame:GetChildren()) do
			if v.Name ~= "StopFollowing" then
				v.Visible = true
			else
				v.Visible = false
			end
		end
	end
end)





-- Draggable
local gui = TopBar
local dragging
local dragInput
local dragStart
local startPos

local function update(input)
	local delta = input.Position - dragStart
	gui.Position = UDim2.new(startPos.X.Scale, startPos.X.Offset + delta.X, startPos.Y.Scale, startPos.Y.Offset + delta.Y)
end

gui.InputBegan:Connect(function(input)
	if input.UserInputType == Enum.UserInputType.MouseButton1 or input.UserInputType == Enum.UserInputType.Touch then
		dragging = true
		dragStart = input.Position
		startPos = gui.Position

		input.Changed:Connect(function()
			if input.UserInputState == Enum.UserInputState.End then
				dragging = false
			end
		end)
	end
end)

gui.InputChanged:Connect(function(input)
	if input.UserInputType == Enum.UserInputType.MouseMovement or input.UserInputType == Enum.UserInputType.Touch then
		dragInput = input
	end
end)

game:GetService("UserInputService").InputChanged:Connect(function(input)
	if input == dragInput and dragging then
		update(input)
	end
end)
