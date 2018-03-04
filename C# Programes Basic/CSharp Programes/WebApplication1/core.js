/**
	 * global namespace function
	 * @param {string} name The namespace to declare, separated by dots (.)
	 * @param {string} [separator] Use a different separator than a dot ).)
	 * 
	 * @description
	 *	<code>
	 *	namespace("com.fiserv.westpac.OTP").test = function(){
	 *		alert("In namespaced com.fiserv.westpac.OTP.test function.");
	 *	};
	 *	</code>
	 * 
	 *	<code>
	 *	namespace("com.fiserv.westpac.OTP.util").someUtilFuncions = {
	 *		key: value,
	 * 		key2: value2
	 *	};
	 *	</code>
	 * @see The <a href="http://blogger.ziesemer.com/2008/05/javascript-namespace-function.html">Original author's blog post</a> 
	 */
(function (window) {

    //locally declare
    var cache = {};

    //create global namespace 
    namespace = function (name, sep) {
        var n = (name) ? name.split(sep || '.') : [],
        o = window,
        i = 0, l = n.length;
        for (i, l; i < l; i = i + 1) {
            //The following line breaks IE7 & 8.
            //o = o[n[i]] = o[n[i]] || {};

            if (!o[n[i]]) {
                o[n[i]] = {};
            }
            o = o[n[i]];
        }
        return o;
    };

    /**
       * global html templating function
       * @param {string} name The namespace to declare, separated by dots (.)
       * @param {string} [separator] Use a different separator than a dot ).)
       * 
       * @description
       *	<code>
       *	namespace("com.fiserv.westpac.OTP").test = function(){
       *		alert("In namespaced com.fiserv.westpac.OTP.test function.");
       *	};
       *	</code>
       * 
       *	<code>
       *	namespace("com.fiserv.westpac.OTP.util").someUtilFuncions = {
       *		key: value,
       * 		key2: value2
       *	};
       *	</code>
       * @see The <a href=" http://ejohn.org/blog/javascript-micro-templating/">John Resig's Templating function</a> 
       */

    namespace('window').template = function template(str, data) {

        //	Use the cache, or create a new function
        var fn = cache[str] ||

        //	Create a cachable template function
        new Function("obj",
          "var p=[],print=function(){p.push.apply(p,arguments);};" +

          // Introduce the data as local variables using with(){}
          "with(obj){p.push('" +

          // Convert the template into JS
          str
          .replace(/[\r\t\n]/g, " ")
          .split("<%").join("\t")
          .replace(/((^|%>)[^\t]*)'/g, "$1\r")
          .replace(/\t=(.*?)%>/g, "',$1,'")
          .split("\t").join("');")
          .split("%>").join("p.push('")
          .split("\r").join("\\'")
          + "');}return p.join('');");

        //	Cache the function
        cache[str] = fn;

        // Provide some basic currying to the user
        return data ? fn(data) : fn;
    };

}(this));
