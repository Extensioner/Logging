# <a href="https://www.nuget.org/packages/Extensioner.Logging/" rel="nofollow">
<img src="https://img.shields.io/nuget/v/Extensioner.Logging.svg?style=flat-square"/> </a>


# 日志静态方法,输出文本文件,基于log4net扩展,轻量,方便,无侵入!

## 使用方法 
1. 导入[nuget](https://www.nuget.org/packages/Extensioner.Logging/)包
2. 导入log4net.config配置文件到应用目录下,修改文件属性为始终复制
3. 程序中使用Log.Debug,Log.Info,Log.Error打印日志
## 示例用法
```
Log.Info("Hello World!");
Log.Debug("Hello World!");
Log.Error("Hello World!", new Exception("NETCore21,Hello World!"));
```
## 效果截图
<img src="https://github.com/Extensioner/Logging/blob/main/Samples/logging.jpg"/>

> 基础框架为.NET Standard 2.0,所以支持.NET Framework 4.6.1之后的所有.NET(包括Core和5)版本
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
# Static log method,output text file,based on log4net,lightweight, convenient, no invasion!

## Usage
1. Import [nuget](https://www.nuget.org/packages/Extensioner.Logging/) package                                        
2. Import the log4net.config into the application directory, and modify the file property to always copy
3. Log.debug, log.info and log.error are used to print logs in the program

## Sample
```
Log.Info("Hello World!");
Log.Debug("Hello World!");
Log.Error("Hello World!", new Exception("NETCore21,Hello World!"));
```
> The basic framework is. NET standard 2.0, so it supports all. NET(including core and 5) versions after. NET framework 4.6.1
