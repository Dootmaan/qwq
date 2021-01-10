# qwq

## Update 2020-01-10
- 更改了窗口属性和图标

## Update 2020-01-05
- 重大更新，改变了颜文字的输入方式，现在是通过直接定位顶层窗口的句柄直接键入颜文字。当然，剪切板也会默认将选中的颜文字复制进来。
- 后续可能会先考虑加上是否同步剪切板的开关
- 添加颜文字的功能遥遥无期


## Update 1.0.1
- 加入颜文字注释，帮助理解
- 加快输入反应速度



## 1.0.0 颜文字输入器，主程序在bin/Release下

原始版本，代码光速堆砌，现在整体非常破碎。下面需要做的几个事情：
- 犹豫怎样实现类似输入法一样的效果，用外挂吗？目前方案是曲线救国，发送按键%{TAB}后发送^v，虽说可以类似的效果，但是因为%{TAB}有不确定的延迟，往往需要等待0.5s，感觉速度不够快，不利于光速刷屏
- 颜文字破碎堆砌，没有条理，闲着没事的时候整理分类一下吧
- 想要做成颜文字可动态删减的样子。甚至想做成每次打开可以自动与我的服务器同步最新颜文字，但这样一来不知道C#还是否适合。
- 界面感觉太土味了  