using System;
using System.IO;

namespace MGCB {
    public static class ContentBuilder {
        public static int BuildContent(out Exception exception, params string[] args) {
            var currentDirectory = Directory.GetCurrentDirectory();
            exception = null;
            var result = 0;

            try {
                result = Program.Main(args);
            }
            catch (Exception e) {
                exception = e;
                result = result == 0 ? -1 : result;
            }
            finally {
                Directory.SetCurrentDirectory(currentDirectory);
            }

            return result;

        }
    }
}
