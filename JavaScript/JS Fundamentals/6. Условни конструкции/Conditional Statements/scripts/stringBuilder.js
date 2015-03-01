function stringBuilder() {
    return {
        arr: [],
        len: 0,
        append: function (str) {
            this.arr[this.len++] = str;
            return this;
        },
        toString: function () {
            return this.arr.join('');
        }
    };
}