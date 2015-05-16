# About

I will give an example of refactoring a static responsive website into an existing web management system (WMS). More specifically this is an example of how a static webpage can be extracted into a Sitecore MVC system.

*   I will use [Sitecore 8](http://www.sitecore.net/ "sitecore") with MVC as the WMS.
*   I will use [Creative Bootstrap theme](http://startbootstrap.com/template-overviews/creative/ "theme link") for the static responsive website.

# Summary

The static website is a one-page website where content and presentation are hard-coded into one big html file. The page is refactored to different sections of views and the content is extracted into the WMS as data sources for the corresponding views. The result is a one Layout, which has sections of views with their data sources. Examples of static and dynamic view binding has been provided, examples of how to use shared data sources and how to code for unknown N items to be rendered.
