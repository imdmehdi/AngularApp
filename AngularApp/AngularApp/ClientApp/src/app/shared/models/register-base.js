"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var RegisterBase = /** @class */ (function () {
    function RegisterBase(options) {
        if (options === void 0) { options = {}; }
        this.value = options.value;
        this.key = options.key || '';
        this.label = options.label || '';
        this.required = !!options.required;
        this.order = options.order === undefined ? 1 : options.order;
        this.controlType = options.controlType || '';
        this.type = options.type || '';
    }
    return RegisterBase;
}());
exports.RegisterBase = RegisterBase;
//# sourceMappingURL=register-base.js.map