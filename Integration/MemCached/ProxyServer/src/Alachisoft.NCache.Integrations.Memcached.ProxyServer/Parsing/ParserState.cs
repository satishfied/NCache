// Copyright (c) 2017 Alachisoft
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//    http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alachisoft.NCache.Integrations.Memcached.ProxyServer.Parsing
{
    enum ParserState
    {
        /// <summary>
        /// Initial state. Ready to parse new command.
        /// </summary>
        Ready,

        /// <summary>
        /// Last parsed command needs data
        /// </summary>
        WaitingForData,

        /// <summary>
        /// Parsed Command is ready to dispatch
        /// </summary>
        ReadyToDispatch
    }
}