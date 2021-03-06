// This isn't compiled into the Feliz.Engine.Bulma package. Copy it to your framework library
// and replace Framework and FrameworkElement appropriately. It isn't necessary, but it may
// help reduce some "bulma.m." boilerplate noise in your app

namespace Framework.Bulma

open Framework

let bulma = Feliz.Engine.Bulma.BulmaEngine<FrameworkElement>( Html, Attr )

//% bulmaModifierLetBindings
