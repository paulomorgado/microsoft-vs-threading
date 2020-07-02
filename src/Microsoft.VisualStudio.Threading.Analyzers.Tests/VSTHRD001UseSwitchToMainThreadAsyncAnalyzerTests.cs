﻿namespace Microsoft.VisualStudio.Threading.Analyzers.Tests
{
    using System.Threading.Tasks;
    using Xunit;
    using Verify = CSharpCodeFixVerifier<VSTHRD001UseSwitchToMainThreadAsyncAnalyzer, CodeAnalysis.Testing.EmptyCodeFixProvider>;

    public class VSTHRD001UseSwitchToMainThreadAsyncAnalyzerTests
    {
        [Fact]
        public async Task ThreadHelperInvoke_ProducesDiagnostic()
        {
            var test = @"
using Microsoft.VisualStudio.Shell;

class Test {
    void Foo() {
        {|#0:ThreadHelper.Generic.Invoke|}(delegate { });
    }
}
";

            await Verify.VerifyAnalyzerAsync(test, Verify.Diagnostic().WithLocation(0));
        }

        [Fact]
        public async Task ThreadHelperBeginInvoke_ProducesDiagnostic()
        {
            var test = @"
using Microsoft.VisualStudio.Shell;

class Test {
    void Foo() {
        {|#0:ThreadHelper.Generic.BeginInvoke|}(delegate { });
    }
}
";

            await Verify.VerifyAnalyzerAsync(test, Verify.Diagnostic().WithLocation(0));
        }

        [Fact]
        public async Task ThreadHelperInvokeAsync_ProducesDiagnostic()
        {
            var test = @"
using Microsoft.VisualStudio.Shell;

class Test {
    void Foo() {
        {|#0:ThreadHelper.Generic.InvokeAsync|}(delegate { });
    }
}
";

            await Verify.VerifyAnalyzerAsync(test, Verify.Diagnostic().WithLocation(0));
        }

        [Fact]
        public async Task DispatcherInvoke_ProducesDiagnostic()
        {
            var test = @"
using System.Windows.Threading;

class Test {
    void Foo() {
        {|#0:Dispatcher.CurrentDispatcher.Invoke|}(delegate { }, DispatcherPriority.ContextIdle);
    }
}
";

            await Verify.VerifyAnalyzerAsync(test, Verify.Diagnostic().WithLocation(0));
        }

        [Fact]
        public async Task DispatcherBeginInvoke_ProducesDiagnostic()
        {
            var test = @"
using System;
using System.Windows.Threading;

class Test {
    void Foo() {
        {|#0:Dispatcher.CurrentDispatcher.BeginInvoke|}(new Action(() => { }));
    }
}
";

            await Verify.VerifyAnalyzerAsync(test, Verify.Diagnostic().WithLocation(0));
        }

        [Fact]
        public async Task DispatcherInvokeAsync_ProducesDiagnostic()
        {
            var test = @"
using System.Windows.Threading;

class Test {
    void Foo() {
        {|#0:Dispatcher.CurrentDispatcher.InvokeAsync|}(delegate { }, DispatcherPriority.ContextIdle);
    }
}
";

            await Verify.VerifyAnalyzerAsync(test, Verify.Diagnostic().WithLocation(0));
        }

        [Fact]
        public async Task SynchronizationContextSend_ProducesDiagnostic()
        {
            var test = @"
using System.Threading;

class Test {
    void Foo() {
        {|#0:SynchronizationContext.Current.Send|}(s => { }, null);
    }
}
";

            await Verify.VerifyAnalyzerAsync(test, Verify.Diagnostic().WithLocation(0));
        }

        [Fact]
        public async Task SynchronizationContextPost_ProducesDiagnostic()
        {
            var test = @"
using System.Threading;

class Test {
    void Foo() {
        {|#0:SynchronizationContext.Current.Post|}(s => { }, null);
    }
}
";

            await Verify.VerifyAnalyzerAsync(test, Verify.Diagnostic().WithLocation(0));
        }
    }
}
