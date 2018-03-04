// use this function if you are not sure if the namespace you need has been already created
Fiserv = {
    namespace: function (namespace, global) {
        /// <summary>Creates a nested object, a pesudo-JavaScript namespace</summary>
        /// <param name="namespace" type="String" optional="false">Namespace to create</param>
        /// <param name="global" type="Object" optional="false">The object to use as the namespace root, if not provided it'll be window</param>
        var go;
        go = function (object, properties) {
            if (properties.length) {
                var propertyToDefine = properties.shift();
                if (typeof object[propertyToDefine] === 'undefined') {
                    object[propertyToDefine] = {};
                }
                go(object[propertyToDefine], properties);
            }
        };
        go(global || (function () { return this; })(), namespace.split('.'));
    }
};
Fiserv.namespace("Fiserv.core");

Fiserv.views = {};
Fiserv.viewmodels = {};
Fiserv.utilities = {};
Fiserv.data = {};
Fiserv.context = {};

Fiserv.events = {
    Handler: function (resource) {
        if (!(this instanceof Fiserv.events.Handler)) return new Fiserv.events.Handler(resource);

        this.receive = function (callback) {
            postman.receive(resource, callback);
        };
        this.deliver = function () {
            postman.deliver(resource, arguments);
            postman.dropMessages(resource);
        };
        this.retract = function (callback) {
            postman.retract(resource, callback);
        };

        return this;
    }
};