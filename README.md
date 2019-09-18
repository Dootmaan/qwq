# qwq
颜文字输入器，主程序在bin/Debug下

---

原始版本，代码光速堆砌，现在整体非常破碎。下面需要做的几个事情：
- 犹豫怎样实现类似输入法一样的效果，用外挂吗？目前方案是曲线救国，发送按键%{TAB}后发送^v，虽说可以类似的效果，但是因为%{TAB}有不确定的延迟，往往需要等待0.5s，感觉速度不够快，不利于光速刷屏
- 颜文字破碎堆砌，没有条理，闲着没事的时候整理分类一下吧
- 想要做成颜文字可动态删减的样子。甚至想做成每次打开可以自动与我的服务器同步最新颜文字，但这样一来不知道C#还是否适合。
- 界面感觉太土味了