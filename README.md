# WCT MVVM Samples Index

## Overview

WCT MVVM Toolkit (Microsoft.Toolkit.Mvvm) WPF Samples.

因为使用了[ModernWpfUI](https://github.com/Kinnara/ModernWpf) 第三方库不支持.Net5+，所以目标框架是.Net48。

WCT MVVM Toolkit 是支持.Net5+的。

## Repository List

<table>
        <thead>
            <tr>
                <th>Repository</th>
                <th>Description</th>
                <th>Keywords</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td><a href="https://github.com/emu2021makuake/MVVMSample001">MVVMSample001</a></td>
                <td><p>Calculator application.</p><p>When you press a button, the calculation result is displayed.</p></td>
                <td>
                    <ul>
                        <li>ObservableObject</li>
                        <li>RelayCommand</li>
                    </ul>
                </td>
            </tr>
            <tr>
                <td><a href="https://github.com/emu2021makuake/MVVMSample002">MVVMSample002</a></td>
                <td><p>A sample of asynchronous processing using AsyncRelayCommand.</p><p>When the button is pressed, it will be in processing for a while.</p></td>
                <td>
                    <ul>
                        <li>ObservableObject</li>
                        <li>AsyncRelayCommand</li>
                    </ul>
                </td>
            </tr>
            <tr>
                <td><a href="https://github.com/emu2021makuake/MVVMSample003">MVVMSample003</a></td>
                <td><p>Sample of sending a string using WeakReferenceMessenger.</p></td>
                <td>
                    <ul>
                        <li>ObservableObject</li>
                        <li>RelayCommand</li>
                        <li>WeakReferenceMessenger</li>
                    </ul>
                </td>
            </tr>
            <tr>
                <td><a href="https://github.com/emu2021makuake/MVVMSample004">MVVMSample004</a></td>
                <td><p>Sample of sending an arbitrary class using WeakReferenceMessenger.</p></td>
                <td>
                    <ul>
                        <li>ObservableObject</li>
                        <li>RelayCommand</li>
                        <li>WeakReferenceMessenger</li>
                    </ul>
                </td>
            </tr>
            <tr>
                <td><a href="https://github.com/emu2021makuake/MVVMSample005">MVVMSample005</a></td>
                <td><p>Sample of sending a message using ObservableRecipient and omitting the WeakReferenceMessenger registration process.</p></td>
                <td>
                    <ul>
                        <li>IRecipient</li>
                        <li>ObservableRecipient</li>
                        <li>RelayCommand</li>
                        <li>WeakReferenceMessenger</li>
                    </ul>
                </td>
            </tr>
            <tr>
                <td><a href="https://github.com/emu2021makuake/MVVMSample006">MVVMSample006</a></td>
                <td><p>Applications that show progress.</p><p>Execution and cancellation of asynchronous processing.</p></td>
                <td>
                    <ul>
                        <li>ObservableObject</li>
                        <li>AsyncRelayCommand</li>
                        <li>CancellationTokenSource</li>
                        <li>Progress</li>
                    </ul>
                </td>
            </tr>
            <tr>
                <td><a href="https://github.com/emu2021makuake/MVVMSample007">MVVMSample007</a></td>
                <td><p>Applications that show progress.</p><p>The difference from MVVMSample006 is that CancellationTokenSource is kept inside HeavyWorkModel.</p></td>
                <td>
                    <ul>
                        <li>ObservableObject</li>
                        <li>AsyncRelayCommand</li>
                        <li>CancellationTokenSource</li>
                        <li>Progress</li>
                    </ul>
                </td>
            </tr>
            <tr>
                <td><a href="https://github.com/emu2021makuake/MVVMSample008">MVVMSample008</a></td>
                <td><p>Validation sample.</p><p>Required check and length check are set in the top TextBox.</p></td>
                <td>
                    <ul>
                        <li>ObservableValidator</li>
                    </ul>
                </td>
            </tr>
            <tr>
                <td><a href="https://github.com/emu2021makuake/MVVMSample009">MVVMSample009</a></td>
                <td><p>Dependency injection sample.</p></td>
                <td>
                    <ul>
                        <li>Ioc</li>
                        <li>ServiceCollection</li>
                    </ul>
                </td>
            </tr>
            <tr>
                <td><a href="https://github.com/emu2021makuake/MVVMSample010">MVVMSample010</a></td>
                <td><p>Event processing sample.</p><p>A screen that cannot be closed while the checkbox is checked.</p></td>
                <td>
                    <ul>
                        <li>RelayCommand&lt;T&gt;</li>
                        <li>Window.Loaded Event</li>
                        <li>Window.Closing Event</li>
                    </ul>
                </td>
            </tr>
            <tr>
                <td><a href="https://github.com/emu2021makuake/MVVMSample011">MVVMSample011</a></td>
                <td><p>Sample of page transition.</p><p>The last page displays the setting values of the previous page.</p></td>
                <td>
                    <ul>
                        <li>ObservableObject</li>
                        <li>RelayCommand</li>
                    </ul>
                </td>
            </tr>
        </tbody>
</table>

<h2>Link</h2>

🌐<a hreflang="ja-jp" href="index.ja.html">日本語ページ(Japanese page)</a>

<hr/>