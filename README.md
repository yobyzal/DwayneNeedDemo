# DwayneNeedDemo

这是一个Demo工程，用于演示使用 `Microsoft.DwayneNeed.Interop` 组件解决 “AirSpace” 问题时，鼠标点击 WinForm 组件会导致主窗口失去焦点的问题。

**重现步骤：**

主窗口 `MainWindow` 中，包括一个使用 `interop:AirspaceDecorator` 包裹的 WinForm `WebBrowser` 组件，和 WPF 的 `Border` 组件。
鼠标点击 `WebBrowser` 组件时主窗口失去焦点，鼠标点击 `Border` 组件时主窗口获得焦点。

**测试环境**

* OS：Windows 10 企业版 Insider Preview. Build 18922.rs_prerelease.190614-1427
* VS2019：16.2.0
